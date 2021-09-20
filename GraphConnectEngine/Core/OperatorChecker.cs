using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphConnectEngine.Core
{
    /// <summary>
    /// TODO op_で解決するようにする
    /// </summary>
    public static class OperatorChecker
    {

        public enum MidOperator
        {
            op_Equality,
            op_Inequality,
            op_GreaterThan,
            op_LessThan,
            op_GreaterThanOrEqual,
            op_LessThanOrEeual,
            op_BitwiseAnd,
            op_BitwiseOr,
            op_Addition, 
            op_Subtraction,
            op_Division,
            op_Modulus,
            op_Multiply, 
            op_LeftShift,
            op_RightShift,
            op_ExclusiveOr
        }

        public enum SingleOperator
        {
            op_UnaryNegation,
            op_UnaryPlus,
            op_OnesComplement,
            op_Increment,
            op_Decrement
        }

        public static Type[] PrimitiveTypes = new[]
        {
            typeof(Boolean),
            typeof(Byte),
            typeof(SByte),
            typeof(Int16),
            typeof(UInt16),
            typeof(Int32),
            typeof(UInt32),
            typeof(Int64),
            typeof(UInt64),
            typeof(Char),
            typeof(Double),
            typeof(Single),
            typeof(Decimal),
            typeof(String),
        };

        public delegate bool ExtentionMidChecker(MidOperator op, Type t1, Type t2, out Type resultType,
            out Func<object, object, object> func);

        public delegate bool ExtentionSingleChecker(SingleOperator op, Type t1, out Type resultType,
            out Func<object, object> func);

        private static Dictionary<string, ExtentionMidChecker> MidExtention =
            new Dictionary<string, ExtentionMidChecker>();

        private static Dictionary<string, ExtentionSingleChecker> SingleExtention =
            new Dictionary<string, ExtentionSingleChecker>();

        public static bool CheckOperator(MidOperator op, Type type1, Type type2,out Type resultType,out Func<object,object,object> func)
        {
            bool isPrimitive = PrimitiveTypes.Contains(type1) && PrimitiveTypes.Contains(type2);
            
            switch (op)
            {
                case MidOperator.op_Addition:
                    if (isPrimitive)
                        return PrimitiveOperatorChecker.CheckAddition(type1, type2, out resultType,out func);
                    break;
                case MidOperator.op_Equality:
                    if (isPrimitive)
                        return PrimitiveOperatorChecker.CheckEquality(type1, type2, out resultType, out func);
                    break;
                case MidOperator.op_GreaterThan:
                    if (isPrimitive)
                        return PrimitiveOperatorChecker.CheckGreaterThan(type1, type2, out resultType, out func);
                    break;
                case MidOperator.op_Modulus:
                    if (isPrimitive)
                        return PrimitiveOperatorChecker.CheckModulus(type1, type2, out resultType, out func);
                    break;
            }

            foreach (var ex in MidExtention.Values)
            {
                if (ex(op, type1, type2, out resultType, out func))
                    return true;
            }
            
            resultType = null;
            func = null;
            return false;
        }

        public static bool CheckOperator(SingleOperator op, Type type1, out Type resultType,
            out Func<object, object> func)
        {
            bool isPrimitive = PrimitiveTypes.Contains(type1);

            switch (op)
            {
                case SingleOperator.op_UnaryPlus:
                    if (isPrimitive)
                        return PrimitiveOperatorChecker.CheckUnaryPlus(type1, out resultType, out func);
                    break;
            }

            foreach (var ex in SingleExtention.Values)
            {
                if (ex(op, type1, out resultType, out func))
                    return true;
            }

            resultType = null;
            func = null;
            return false;
        }

        public static void AddExtention(string sender, ExtentionMidChecker checker)
        {
            if (!MidExtention.ContainsKey(sender))
            {
                MidExtention[sender] = checker;
            }
        }

        public static void AddExtention(string sender, ExtentionSingleChecker checker)
        {
            if (!SingleExtention.ContainsKey(sender))
            {
                SingleExtention[sender] = checker;
            }
        }
    }
}
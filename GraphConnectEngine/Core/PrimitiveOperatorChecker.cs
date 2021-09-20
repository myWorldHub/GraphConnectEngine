using System;

namespace GraphConnectEngine.Core
{
    public class PrimitiveOperatorChecker
    {
        
    public static bool CheckEquality(Type type1, Type type2, out Type result,out Func<object,object,object> func)
    {
    
        if(type1 == typeof(Boolean) && type2 == typeof(Boolean))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Boolean)obj1 == (Boolean)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 == (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 == (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 == (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 == (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 == (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 == (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 == (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 == (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 == (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 == (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 == (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 == (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 == (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 == (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 == (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 == (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 == (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 == (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 == (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 == (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 == (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 == (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 == (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 == (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 == (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 == (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 == (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 == (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 == (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 == (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 == (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 == (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 == (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 == (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 == (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 == (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 == (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 == (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 == (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 == (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 == (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 == (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 == (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 == (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 == (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 == (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 == (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 == (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 == (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 == (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 == (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 == (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 == (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 == (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 == (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 == (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 == (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 == (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 == (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 == (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 == (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 == (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 == (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 == (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 == (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 == (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 == (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 == (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 == (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 == (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 == (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 == (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 == (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 == (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 == (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 == (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 == (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 == (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 == (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 == (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 == (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 == (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 == (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 == (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 == (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 == (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 == (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 == (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 == (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 == (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 == (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 == (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 == (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 == (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 == (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 == (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 == (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 == (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 == (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 == (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 == (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 == (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 == (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 == (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 == (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 == (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 == (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 == (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 == (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 == (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 == (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 == (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 == (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 == (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 == (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 == (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 == (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 == (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 == (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 == (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 == (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 == (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 == (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 == (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 == (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 == (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 == (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 == (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 == (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 == (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 == (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(String) && type2 == typeof(String))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (String)obj1 == (String)obj2;
            return true;
        }
    
        result = null;
        func = null;
        return false;
    }
    
    public static bool CheckInequality(Type type1, Type type2, out Type result,out Func<object,object,object> func)
    {
    
        if(type1 == typeof(Boolean) && type2 == typeof(Boolean))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Boolean)obj1 != (Boolean)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 != (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 != (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 != (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 != (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 != (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 != (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 != (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 != (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 != (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 != (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 != (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 != (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 != (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 != (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 != (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 != (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 != (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 != (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 != (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 != (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 != (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 != (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 != (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 != (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 != (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 != (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 != (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 != (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 != (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 != (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 != (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 != (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 != (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 != (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 != (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 != (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 != (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 != (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 != (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 != (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 != (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 != (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 != (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 != (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 != (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 != (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 != (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 != (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 != (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 != (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 != (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 != (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 != (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 != (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 != (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 != (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 != (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 != (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 != (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 != (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 != (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 != (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 != (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 != (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 != (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 != (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 != (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 != (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 != (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 != (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 != (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 != (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 != (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 != (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 != (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 != (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 != (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 != (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 != (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 != (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 != (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 != (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 != (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 != (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 != (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 != (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 != (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 != (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 != (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 != (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 != (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 != (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 != (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 != (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 != (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 != (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 != (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 != (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 != (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 != (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 != (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 != (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 != (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 != (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 != (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 != (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 != (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 != (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 != (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 != (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 != (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 != (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 != (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 != (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 != (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 != (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 != (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 != (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 != (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 != (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 != (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 != (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 != (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 != (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 != (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 != (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 != (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 != (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 != (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 != (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 != (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 != (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(String) && type2 == typeof(String))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (String)obj1 != (String)obj2;
            return true;
        }
    
        result = null;
        func = null;
        return false;
    }
    
    public static bool CheckGreaterThan(Type type1, Type type2, out Type result,out Func<object,object,object> func)
    {
    
        if(type1 == typeof(Byte) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 > (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 > (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 > (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 > (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 > (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 > (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 > (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 > (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 > (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 > (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 > (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 > (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 > (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 > (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 > (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 > (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 > (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 > (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 > (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 > (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 > (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 > (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 > (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 > (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 > (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 > (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 > (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 > (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 > (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 > (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 > (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 > (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 > (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 > (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 > (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 > (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 > (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 > (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 > (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 > (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 > (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 > (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 > (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 > (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 > (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 > (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 > (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 > (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 > (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 > (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 > (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 > (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 > (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 > (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 > (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 > (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 > (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 > (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 > (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 > (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 > (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 > (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 > (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 > (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 > (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 > (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 > (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 > (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 > (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 > (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 > (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 > (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 > (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 > (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 > (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 > (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 > (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 > (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 > (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 > (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 > (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 > (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 > (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 > (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 > (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 > (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 > (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 > (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 > (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 > (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 > (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 > (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 > (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 > (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 > (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 > (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 > (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 > (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 > (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 > (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 > (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 > (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 > (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 > (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 > (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 > (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 > (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 > (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 > (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 > (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 > (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 > (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 > (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 > (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 > (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 > (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 > (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 > (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 > (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 > (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 > (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 > (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 > (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 > (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 > (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 > (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 > (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 > (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 > (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 > (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 > (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 > (Decimal)obj2;
            return true;
        }
    
        result = null;
        func = null;
        return false;
    }
    
    public static bool CheckLessThan(Type type1, Type type2, out Type result,out Func<object,object,object> func)
    {
    
        if(type1 == typeof(Byte) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 < (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 < (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 < (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 < (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 < (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 < (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 < (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 < (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 < (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 < (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 < (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 < (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 < (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 < (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 < (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 < (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 < (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 < (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 < (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 < (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 < (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 < (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 < (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 < (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 < (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 < (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 < (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 < (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 < (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 < (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 < (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 < (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 < (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 < (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 < (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 < (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 < (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 < (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 < (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 < (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 < (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 < (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 < (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 < (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 < (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 < (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 < (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 < (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 < (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 < (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 < (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 < (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 < (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 < (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 < (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 < (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 < (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 < (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 < (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 < (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 < (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 < (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 < (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 < (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 < (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 < (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 < (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 < (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 < (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 < (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 < (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 < (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 < (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 < (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 < (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 < (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 < (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 < (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 < (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 < (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 < (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 < (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 < (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 < (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 < (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 < (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 < (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 < (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 < (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 < (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 < (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 < (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 < (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 < (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 < (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 < (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 < (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 < (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 < (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 < (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 < (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 < (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 < (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 < (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 < (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 < (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 < (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 < (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 < (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 < (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 < (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 < (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 < (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 < (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 < (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 < (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 < (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 < (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 < (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 < (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 < (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 < (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 < (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 < (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 < (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 < (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 < (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 < (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 < (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 < (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 < (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 < (Decimal)obj2;
            return true;
        }
    
        result = null;
        func = null;
        return false;
    }
    
    public static bool CheckGreaterThanOrEqual(Type type1, Type type2, out Type result,out Func<object,object,object> func)
    {
    
        if(type1 == typeof(Byte) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 >= (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 >= (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 >= (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 >= (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 >= (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 >= (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 >= (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 >= (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 >= (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 >= (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 >= (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 >= (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 >= (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 >= (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 >= (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 >= (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 >= (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 >= (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 >= (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 >= (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 >= (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 >= (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 >= (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 >= (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 >= (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 >= (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 >= (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 >= (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 >= (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 >= (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 >= (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 >= (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 >= (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 >= (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 >= (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 >= (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 >= (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 >= (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 >= (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 >= (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 >= (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 >= (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 >= (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 >= (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 >= (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 >= (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 >= (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 >= (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 >= (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 >= (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 >= (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 >= (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 >= (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 >= (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 >= (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 >= (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 >= (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 >= (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 >= (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 >= (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 >= (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 >= (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 >= (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 >= (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 >= (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 >= (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 >= (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 >= (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 >= (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 >= (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 >= (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 >= (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 >= (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 >= (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 >= (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 >= (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 >= (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 >= (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 >= (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 >= (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 >= (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 >= (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 >= (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 >= (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 >= (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 >= (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 >= (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 >= (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 >= (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 >= (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 >= (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 >= (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 >= (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 >= (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 >= (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 >= (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 >= (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 >= (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 >= (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 >= (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 >= (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 >= (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 >= (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 >= (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 >= (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 >= (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 >= (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 >= (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 >= (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 >= (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 >= (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 >= (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 >= (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 >= (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 >= (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 >= (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 >= (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 >= (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 >= (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 >= (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 >= (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 >= (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 >= (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 >= (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 >= (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 >= (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 >= (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 >= (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 >= (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 >= (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 >= (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 >= (Decimal)obj2;
            return true;
        }
    
        result = null;
        func = null;
        return false;
    }
    
    public static bool CheckLessThanOrEqual(Type type1, Type type2, out Type result,out Func<object,object,object> func)
    {
    
        if(type1 == typeof(Byte) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 <= (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 <= (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 <= (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 <= (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 <= (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 <= (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 <= (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 <= (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 <= (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 <= (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 <= (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Byte)obj1 <= (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 <= (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 <= (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 <= (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 <= (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 <= (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 <= (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 <= (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 <= (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 <= (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 <= (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (SByte)obj1 <= (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 <= (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 <= (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 <= (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 <= (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 <= (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 <= (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 <= (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 <= (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 <= (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 <= (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int16)obj1 <= (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 <= (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 <= (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 <= (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 <= (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 <= (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 <= (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 <= (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 <= (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 <= (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 <= (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 <= (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt16)obj1 <= (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 <= (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 <= (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 <= (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 <= (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 <= (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 <= (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 <= (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 <= (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 <= (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 <= (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int32)obj1 <= (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 <= (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 <= (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 <= (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 <= (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 <= (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 <= (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 <= (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 <= (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 <= (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 <= (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 <= (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt32)obj1 <= (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 <= (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 <= (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 <= (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 <= (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 <= (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 <= (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 <= (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 <= (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 <= (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 <= (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Int64)obj1 <= (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 <= (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 <= (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 <= (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 <= (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 <= (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 <= (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 <= (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (UInt64)obj1 <= (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 <= (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 <= (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 <= (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 <= (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 <= (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 <= (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 <= (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 <= (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 <= (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 <= (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 <= (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Char)obj1 <= (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 <= (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 <= (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 <= (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 <= (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 <= (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 <= (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 <= (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 <= (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 <= (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 <= (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Double)obj1 <= (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 <= (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 <= (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 <= (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 <= (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 <= (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 <= (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 <= (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 <= (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 <= (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Double))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 <= (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Single))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Single)obj1 <= (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Byte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 <= (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(SByte))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 <= (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 <= (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt16))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 <= (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 <= (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt32))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 <= (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 <= (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt64))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 <= (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Char))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 <= (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Decimal))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Decimal)obj1 <= (Decimal)obj2;
            return true;
        }
    
        result = null;
        func = null;
        return false;
    }
    
    public static bool CheckBitwiseAnd(Type type1, Type type2, out Type result,out Func<object,object,object> func)
    {
    
        if(type1 == typeof(Boolean) && type2 == typeof(Boolean))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Boolean)obj1 & (Boolean)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 & (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 & (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 & (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 & (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 & (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (Byte)obj1 & (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Byte)obj1 & (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (Byte)obj1 & (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 & (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 & (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 & (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 & (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 & (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 & (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (SByte)obj1 & (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (SByte)obj1 & (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 & (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 & (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 & (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 & (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 & (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 & (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int16)obj1 & (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int16)obj1 & (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 & (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 & (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 & (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 & (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 & (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 & (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt16)obj1 & (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt16)obj1 & (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt16)obj1 & (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 & (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 & (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 & (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 & (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 & (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 & (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int32)obj1 & (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int32)obj1 & (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 & (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Byte))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 & (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(SByte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 & (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 & (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt16))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 & (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 & (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 & (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 & (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt32)obj1 & (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Char))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 & (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Byte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 & (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(SByte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 & (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 & (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 & (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 & (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 & (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 & (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Char))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 & (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Byte))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 & (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt16))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 & (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 & (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 & (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Char))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 & (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 & (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 & (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 & (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 & (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 & (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (Char)obj1 & (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Char)obj1 & (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (Char)obj1 & (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 & (Char)obj2;
            return true;
        }
    
        result = null;
        func = null;
        return false;
    }
    
    public static bool CheckBitwiseOr(Type type1, Type type2, out Type result,out Func<object,object,object> func)
    {
    
        if(type1 == typeof(Boolean) && type2 == typeof(Boolean))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Boolean)obj1 | (Boolean)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 | (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 | (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 | (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 | (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (Byte)obj1 | (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Byte)obj1 | (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (Byte)obj1 | (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 | (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 | (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 | (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 | (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 | (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 | (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 | (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 | (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 | (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 | (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt16)obj1 | (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt16)obj1 | (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt16)obj1 | (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 | (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 | (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 | (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 | (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 | (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 | (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Byte))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 | (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt16))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 | (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 | (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 | (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt32)obj1 | (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Char))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 | (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Byte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 | (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 | (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 | (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 | (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Char))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 | (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Byte))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 | (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt16))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 | (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 | (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 | (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Char))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 | (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 | (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 | (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 | (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 | (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (Char)obj1 | (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Char)obj1 | (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (Char)obj1 | (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 | (Char)obj2;
            return true;
        }
    
        result = null;
        func = null;
        return false;
    }
    
    public static bool CheckAddition(Type type1, Type type2, out Type result,out Func<object,object,object> func)
    {
    
        if(type1 == typeof(Boolean) && type2 == typeof(String))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (Boolean)obj1 + (String)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 + (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 + (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 + (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 + (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (Byte)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Byte)obj1 + (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (Byte)obj1 + (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 + (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Byte)obj1 + (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Byte)obj1 + (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Byte)obj1 + (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(String))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (Byte)obj1 + (String)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 + (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 + (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 + (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 + (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (SByte)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (SByte)obj1 + (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 + (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (SByte)obj1 + (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (SByte)obj1 + (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (SByte)obj1 + (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(String))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (SByte)obj1 + (String)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 + (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 + (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 + (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 + (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int16)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int16)obj1 + (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 + (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Int16)obj1 + (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Int16)obj1 + (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Int16)obj1 + (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(String))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (Int16)obj1 + (String)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 + (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 + (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 + (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 + (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt16)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt16)obj1 + (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt16)obj1 + (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 + (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (UInt16)obj1 + (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (UInt16)obj1 + (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(String))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (UInt16)obj1 + (String)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 + (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 + (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 + (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 + (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int32)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int32)obj1 + (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 + (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Int32)obj1 + (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Int32)obj1 + (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Int32)obj1 + (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(String))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (Int32)obj1 + (String)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Byte))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 + (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(SByte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 + (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 + (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt16))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 + (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 + (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt32)obj1 + (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Char))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 + (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (UInt32)obj1 + (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (UInt32)obj1 + (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (UInt32)obj1 + (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(String))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (UInt32)obj1 + (String)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Byte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 + (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(SByte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 + (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 + (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 + (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 + (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Char))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 + (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Int64)obj1 + (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Int64)obj1 + (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Int64)obj1 + (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(String))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (Int64)obj1 + (String)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Byte))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 + (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt16))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 + (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Char))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 + (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (UInt64)obj1 + (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (UInt64)obj1 + (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (UInt64)obj1 + (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(String))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (UInt64)obj1 + (String)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 + (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 + (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 + (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 + (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (Char)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Char)obj1 + (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (Char)obj1 + (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 + (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Char)obj1 + (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Char)obj1 + (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Char)obj1 + (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(String))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (Char)obj1 + (String)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Byte))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 + (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(SByte))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 + (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int16))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 + (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt16))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int32))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 + (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt32))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int64))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 + (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt64))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 + (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Char))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 + (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 + (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Single))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 + (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(String))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (Double)obj1 + (String)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Byte))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 + (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(SByte))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 + (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int16))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 + (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt16))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int32))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 + (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt32))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int64))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 + (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt64))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 + (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Char))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 + (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Single)obj1 + (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 + (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(String))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (Single)obj1 + (String)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Byte))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 + (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(SByte))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 + (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int16))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 + (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt16))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int32))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 + (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt32))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int64))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 + (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt64))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 + (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Char))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 + (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 + (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(String))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (Decimal)obj1 + (String)obj2;
            return true;
        }
    
        if(type1 == typeof(String) && type2 == typeof(Boolean))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (String)obj1 + (Boolean)obj2;
            return true;
        }
    
        if(type1 == typeof(String) && type2 == typeof(Byte))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (String)obj1 + (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(String) && type2 == typeof(SByte))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (String)obj1 + (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(String) && type2 == typeof(Int16))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (String)obj1 + (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(String) && type2 == typeof(UInt16))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (String)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(String) && type2 == typeof(Int32))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (String)obj1 + (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(String) && type2 == typeof(UInt32))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (String)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(String) && type2 == typeof(Int64))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (String)obj1 + (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(String) && type2 == typeof(UInt64))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (String)obj1 + (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(String) && type2 == typeof(Char))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (String)obj1 + (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(String) && type2 == typeof(Double))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (String)obj1 + (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(String) && type2 == typeof(Single))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (String)obj1 + (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(String) && type2 == typeof(Decimal))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (String)obj1 + (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(String) && type2 == typeof(String))
        {
            result = typeof(System.String);
            func = (object obj1, object obj2) => (String)obj1 + (String)obj2;
            return true;
        }
    
        result = null;
        func = null;
        return false;
    }
    
    public static bool CheckSubtraction(Type type1, Type type2, out Type result,out Func<object,object,object> func)
    {
    
        if(type1 == typeof(Byte) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 - (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 - (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 - (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 - (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 - (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (Byte)obj1 - (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Byte)obj1 - (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (Byte)obj1 - (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 - (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Byte)obj1 - (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Byte)obj1 - (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Byte)obj1 - (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 - (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 - (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 - (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 - (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 - (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (SByte)obj1 - (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (SByte)obj1 - (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 - (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (SByte)obj1 - (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (SByte)obj1 - (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 - (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 - (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 - (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 - (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 - (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int16)obj1 - (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int16)obj1 - (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 - (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Int16)obj1 - (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Int16)obj1 - (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Int16)obj1 - (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 - (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 - (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 - (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 - (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 - (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt16)obj1 - (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt16)obj1 - (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt16)obj1 - (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 - (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (UInt16)obj1 - (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (UInt16)obj1 - (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (UInt16)obj1 - (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 - (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 - (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 - (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 - (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 - (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int32)obj1 - (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int32)obj1 - (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 - (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Int32)obj1 - (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Int32)obj1 - (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Int32)obj1 - (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Byte))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 - (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(SByte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 - (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 - (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt16))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 - (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 - (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 - (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 - (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt32)obj1 - (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Char))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 - (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (UInt32)obj1 - (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (UInt32)obj1 - (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (UInt32)obj1 - (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Byte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 - (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(SByte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 - (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 - (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 - (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 - (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 - (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 - (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Char))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 - (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Int64)obj1 - (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Int64)obj1 - (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Int64)obj1 - (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Byte))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 - (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt16))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 - (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 - (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 - (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Char))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 - (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (UInt64)obj1 - (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (UInt64)obj1 - (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (UInt64)obj1 - (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 - (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 - (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 - (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 - (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 - (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (Char)obj1 - (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Char)obj1 - (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (Char)obj1 - (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 - (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Char)obj1 - (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Char)obj1 - (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Char)obj1 - (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Byte))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 - (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(SByte))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 - (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int16))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 - (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt16))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 - (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int32))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 - (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt32))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 - (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int64))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 - (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt64))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 - (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Char))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 - (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 - (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Single))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 - (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Byte))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 - (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(SByte))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 - (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int16))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 - (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt16))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 - (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int32))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 - (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt32))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 - (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int64))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 - (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt64))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 - (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Char))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 - (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Single)obj1 - (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 - (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Byte))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 - (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(SByte))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 - (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int16))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 - (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt16))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 - (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int32))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 - (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt32))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 - (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int64))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 - (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt64))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 - (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Char))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 - (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 - (Decimal)obj2;
            return true;
        }
    
        result = null;
        func = null;
        return false;
    }
    
    public static bool CheckDivision(Type type1, Type type2, out Type result,out Func<object,object,object> func)
    {
    
        if(type1 == typeof(Byte) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 / (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 / (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 / (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 / (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 / (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Byte)obj1 / (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (Byte)obj1 / (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 / (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Byte)obj1 / (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Byte)obj1 / (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Byte)obj1 / (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 / (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 / (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 / (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 / (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 / (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (SByte)obj1 / (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (SByte)obj1 / (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 / (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (SByte)obj1 / (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (SByte)obj1 / (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (SByte)obj1 / (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 / (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 / (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 / (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 / (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 / (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int16)obj1 / (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int16)obj1 / (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 / (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Int16)obj1 / (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Int16)obj1 / (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Int16)obj1 / (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 / (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 / (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 / (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 / (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 / (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt16)obj1 / (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt16)obj1 / (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt16)obj1 / (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 / (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (UInt16)obj1 / (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (UInt16)obj1 / (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (UInt16)obj1 / (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 / (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 / (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 / (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 / (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 / (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int32)obj1 / (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int32)obj1 / (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 / (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Int32)obj1 / (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Int32)obj1 / (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Int32)obj1 / (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Byte))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 / (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(SByte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 / (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 / (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt16))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 / (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 / (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 / (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 / (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt32)obj1 / (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Char))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 / (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (UInt32)obj1 / (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (UInt32)obj1 / (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (UInt32)obj1 / (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Byte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 / (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(SByte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 / (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 / (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 / (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 / (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 / (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 / (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Char))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 / (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Int64)obj1 / (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Int64)obj1 / (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Int64)obj1 / (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Byte))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 / (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt16))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 / (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 / (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 / (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Char))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 / (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (UInt64)obj1 / (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (UInt64)obj1 / (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (UInt64)obj1 / (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 / (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 / (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 / (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 / (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 / (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (Char)obj1 / (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Char)obj1 / (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (Char)obj1 / (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 / (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Char)obj1 / (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Char)obj1 / (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Char)obj1 / (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Byte))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 / (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(SByte))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 / (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int16))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 / (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt16))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 / (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int32))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 / (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt32))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 / (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int64))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 / (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt64))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 / (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Char))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 / (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 / (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Single))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 / (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Byte))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 / (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(SByte))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 / (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int16))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 / (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt16))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 / (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int32))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 / (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt32))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 / (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int64))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 / (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt64))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 / (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Char))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 / (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Single)obj1 / (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 / (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Byte))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 / (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(SByte))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 / (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int16))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 / (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt16))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 / (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int32))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 / (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt32))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 / (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int64))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 / (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt64))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 / (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Char))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 / (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 / (Decimal)obj2;
            return true;
        }
    
        result = null;
        func = null;
        return false;
    }
    
    public static bool CheckModulus(Type type1, Type type2, out Type result,out Func<object,object,object> func)
    {
    
        if(type1 == typeof(Byte) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 % (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 % (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 % (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 % (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 % (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (Byte)obj1 % (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Byte)obj1 % (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (Byte)obj1 % (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 % (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Byte)obj1 % (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Byte)obj1 % (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Byte)obj1 % (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 % (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 % (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 % (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 % (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 % (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (SByte)obj1 % (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (SByte)obj1 % (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 % (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (SByte)obj1 % (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (SByte)obj1 % (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (SByte)obj1 % (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 % (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 % (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 % (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 % (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 % (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int16)obj1 % (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int16)obj1 % (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 % (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Int16)obj1 % (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Int16)obj1 % (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Int16)obj1 % (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 % (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 % (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 % (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 % (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 % (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt16)obj1 % (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt16)obj1 % (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt16)obj1 % (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 % (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (UInt16)obj1 % (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (UInt16)obj1 % (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (UInt16)obj1 % (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 % (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 % (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 % (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 % (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 % (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int32)obj1 % (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int32)obj1 % (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 % (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Int32)obj1 % (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Int32)obj1 % (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Int32)obj1 % (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Byte))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 % (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(SByte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 % (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 % (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt16))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 % (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 % (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 % (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 % (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt32)obj1 % (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Char))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 % (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (UInt32)obj1 % (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (UInt32)obj1 % (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (UInt32)obj1 % (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Byte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 % (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(SByte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 % (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 % (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 % (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 % (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 % (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 % (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Char))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 % (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Int64)obj1 % (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Int64)obj1 % (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Int64)obj1 % (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Byte))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 % (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt16))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 % (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 % (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 % (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Char))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 % (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (UInt64)obj1 % (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (UInt64)obj1 % (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (UInt64)obj1 % (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 % (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 % (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 % (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 % (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 % (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (Char)obj1 % (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Char)obj1 % (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (Char)obj1 % (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 % (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Char)obj1 % (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Char)obj1 % (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Char)obj1 % (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Byte))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 % (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(SByte))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 % (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int16))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 % (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt16))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 % (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int32))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 % (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt32))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 % (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int64))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 % (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt64))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 % (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Char))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 % (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 % (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Single))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 % (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Byte))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 % (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(SByte))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 % (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int16))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 % (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt16))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 % (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int32))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 % (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt32))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 % (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int64))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 % (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt64))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 % (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Single)obj1 % (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 % (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Byte))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 % (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(SByte))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 % (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int16))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 % (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt16))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 % (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int32))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 % (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt32))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 % (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int64))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 % (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt64))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 % (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Char))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 % (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 % (Decimal)obj2;
            return true;
        }
    
        result = null;
        func = null;
        return false;
    }
    
    public static bool CheckMultiply(Type type1, Type type2, out Type result,out Func<object,object,object> func)
    {
    
        if(type1 == typeof(Byte) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 * (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 * (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 * (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 * (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 * (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (Byte)obj1 * (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Byte)obj1 * (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (Byte)obj1 * (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 * (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Byte)obj1 * (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Byte)obj1 * (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Byte)obj1 * (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 * (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 * (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 * (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 * (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 * (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (SByte)obj1 * (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (SByte)obj1 * (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 * (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (SByte)obj1 * (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (SByte)obj1 * (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (SByte)obj1 * (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 * (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 * (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 * (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 * (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 * (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int16)obj1 * (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int16)obj1 * (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 * (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Int16)obj1 * (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Int16)obj1 * (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Int16)obj1 * (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 * (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 * (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 * (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 * (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 * (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt16)obj1 * (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt16)obj1 * (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt16)obj1 * (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 * (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (UInt16)obj1 * (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (UInt16)obj1 * (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (UInt16)obj1 * (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 * (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 * (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 * (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 * (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 * (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int32)obj1 * (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int32)obj1 * (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 * (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Int32)obj1 * (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Int32)obj1 * (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Int32)obj1 * (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Byte))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 * (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(SByte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 * (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 * (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt16))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 * (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 * (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 * (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 * (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt32)obj1 * (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Char))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 * (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (UInt32)obj1 * (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (UInt32)obj1 * (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (UInt32)obj1 * (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Byte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 * (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(SByte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 * (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 * (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 * (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 * (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 * (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 * (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Char))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 * (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Int64)obj1 * (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Int64)obj1 * (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Int64)obj1 * (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Byte))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 * (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt16))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 * (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 * (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 * (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Char))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 * (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (UInt64)obj1 * (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (UInt64)obj1 * (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (UInt64)obj1 * (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 * (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 * (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 * (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 * (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 * (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (Char)obj1 * (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Char)obj1 * (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 * (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Char)obj1 * (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Char)obj1 * (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Char)obj1 * (Decimal)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Byte))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 * (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int16))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 * (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt16))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 * (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int32))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 * (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt32))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 * (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Int64))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 * (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(UInt64))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 * (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Char))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 * (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 * (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Double) && type2 == typeof(Single))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Double)obj1 * (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Byte))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 * (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(SByte))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 * (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int16))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 * (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt16))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 * (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int32))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 * (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt32))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 * (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Int64))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 * (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(UInt64))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 * (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Char))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 * (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1, object obj2) => (Single)obj1 * (Double)obj2;
            return true;
        }
    
        if(type1 == typeof(Single) && type2 == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1, object obj2) => (Single)obj1 * (Single)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Byte))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 * (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(SByte))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 * (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int16))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 * (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt16))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 * (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int32))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 * (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt32))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 * (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Int64))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 * (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(UInt64))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 * (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Char))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 * (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Decimal) && type2 == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1, object obj2) => (Decimal)obj1 * (Decimal)obj2;
            return true;
        }
    
        result = null;
        func = null;
        return false;
    }
    
    public static bool CheckLeftShift(Type type1, Type type2, out Type result,out Func<object,object,object> func)
    {
    
        if(type1 == typeof(Byte) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 << (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 << (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 << (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 << (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 << (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 << (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 << (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 << (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 << (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 << (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 << (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 << (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 << (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 << (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 << (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 << (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 << (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 << (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 << (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 << (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 << (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 << (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 << (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 << (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 << (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 << (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 << (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 << (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 << (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 << (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Byte))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 << (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(SByte))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 << (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int16))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 << (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt16))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 << (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 << (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Char))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 << (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Byte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 << (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(SByte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 << (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 << (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 << (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 << (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Char))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 << (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Byte))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 << (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(SByte))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 << (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Int16))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 << (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt16))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 << (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Int32))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 << (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Char))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 << (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 << (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 << (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 << (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 << (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 << (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 << (Char)obj2;
            return true;
        }
    
        result = null;
        func = null;
        return false;
    }
    
    public static bool CheckRightShift(Type type1, Type type2, out Type result,out Func<object,object,object> func)
    {
    
        if(type1 == typeof(Byte) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 >> (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 >> (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 >> (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 >> (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 >> (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 >> (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 >> (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 >> (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 >> (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 >> (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 >> (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 >> (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 >> (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 >> (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 >> (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 >> (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 >> (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 >> (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 >> (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 >> (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 >> (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 >> (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 >> (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 >> (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 >> (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 >> (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 >> (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 >> (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 >> (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 >> (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Byte))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 >> (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(SByte))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 >> (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int16))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 >> (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt16))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 >> (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 >> (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Char))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 >> (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Byte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 >> (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(SByte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 >> (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 >> (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 >> (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 >> (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Char))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 >> (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Byte))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 >> (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(SByte))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 >> (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Int16))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 >> (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt16))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 >> (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Int32))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 >> (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Char))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 >> (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 >> (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 >> (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 >> (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 >> (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 >> (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 >> (Char)obj2;
            return true;
        }
    
        result = null;
        func = null;
        return false;
    }
    
    public static bool CheckExclusiveOr(Type type1, Type type2, out Type result,out Func<object,object,object> func)
    {
    
        if(type1 == typeof(Boolean) && type2 == typeof(Boolean))
        {
            result = typeof(System.Boolean);
            func = (object obj1, object obj2) => (Boolean)obj1 ^ (Boolean)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 ^ (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 ^ (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 ^ (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 ^ (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 ^ (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (Byte)obj1 ^ (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Byte)obj1 ^ (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (Byte)obj1 ^ (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Byte) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Byte)obj1 ^ (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 ^ (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 ^ (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 ^ (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 ^ (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 ^ (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (SByte)obj1 ^ (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (SByte)obj1 ^ (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(SByte) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (SByte)obj1 ^ (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 ^ (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 ^ (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 ^ (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 ^ (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 ^ (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int16)obj1 ^ (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int16)obj1 ^ (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int16) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int16)obj1 ^ (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 ^ (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 ^ (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 ^ (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 ^ (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 ^ (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt16)obj1 ^ (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt16)obj1 ^ (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt16)obj1 ^ (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt16) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (UInt16)obj1 ^ (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 ^ (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 ^ (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 ^ (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 ^ (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 ^ (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int32)obj1 ^ (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int32)obj1 ^ (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int32) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Int32)obj1 ^ (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Byte))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 ^ (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(SByte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 ^ (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 ^ (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt16))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 ^ (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 ^ (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 ^ (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (UInt32)obj1 ^ (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt32)obj1 ^ (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt32) && type2 == typeof(Char))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (UInt32)obj1 ^ (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Byte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 ^ (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(SByte))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 ^ (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 ^ (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 ^ (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 ^ (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 ^ (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 ^ (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Int64) && type2 == typeof(Char))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Int64)obj1 ^ (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Byte))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 ^ (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt16))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 ^ (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 ^ (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 ^ (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(UInt64) && type2 == typeof(Char))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (UInt64)obj1 ^ (Char)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 ^ (Byte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 ^ (SByte)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 ^ (Int16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 ^ (UInt16)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 ^ (Int32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1, object obj2) => (Char)obj1 ^ (UInt32)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1, object obj2) => (Char)obj1 ^ (Int64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1, object obj2) => (Char)obj1 ^ (UInt64)obj2;
            return true;
        }
    
        if(type1 == typeof(Char) && type2 == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1, object obj2) => (Char)obj1 ^ (Char)obj2;
            return true;
        }
    
        result = null;
        func = null;
        return false;
    }
    
    public static bool CheckUnaryNegation(Type type, out Type result, out Func<object,object> func)
    {
    
        if(type == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1) => {
                Byte ggg = (Byte)obj1;
                return -ggg;
            };
            return true;
        }
    
        if(type == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1) => {
                SByte ggg = (SByte)obj1;
                return -ggg;
            };
            return true;
        }
    
        if(type == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1) => {
                Int16 ggg = (Int16)obj1;
                return -ggg;
            };
            return true;
        }
    
        if(type == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1) => {
                UInt16 ggg = (UInt16)obj1;
                return -ggg;
            };
            return true;
        }
    
        if(type == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1) => {
                Int32 ggg = (Int32)obj1;
                return -ggg;
            };
            return true;
        }
    
        if(type == typeof(UInt32))
        {
            result = typeof(System.Int64);
            func = (object obj1) => {
                UInt32 ggg = (UInt32)obj1;
                return -ggg;
            };
            return true;
        }
    
        if(type == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1) => {
                Int64 ggg = (Int64)obj1;
                return -ggg;
            };
            return true;
        }
    
        if(type == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1) => {
                Char ggg = (Char)obj1;
                return -ggg;
            };
            return true;
        }
    
        if(type == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1) => {
                Double ggg = (Double)obj1;
                return -ggg;
            };
            return true;
        }
    
        if(type == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1) => {
                Single ggg = (Single)obj1;
                return -ggg;
            };
            return true;
        }
    
        if(type == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1) => {
                Decimal ggg = (Decimal)obj1;
                return -ggg;
            };
            return true;
        }
    
        result = null;
        func = null;
        return false;
    }
    
    public static bool CheckUnaryPlus(Type type, out Type result, out Func<object,object> func)
    {
    
        if(type == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1) => {
                Byte ggg = (Byte)obj1;
                return +ggg;
            };
            return true;
        }
    
        if(type == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1) => {
                SByte ggg = (SByte)obj1;
                return +ggg;
            };
            return true;
        }
    
        if(type == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1) => {
                Int16 ggg = (Int16)obj1;
                return +ggg;
            };
            return true;
        }
    
        if(type == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1) => {
                UInt16 ggg = (UInt16)obj1;
                return +ggg;
            };
            return true;
        }
    
        if(type == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1) => {
                Int32 ggg = (Int32)obj1;
                return +ggg;
            };
            return true;
        }
    
        if(type == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1) => {
                UInt32 ggg = (UInt32)obj1;
                return +ggg;
            };
            return true;
        }
    
        if(type == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1) => {
                Int64 ggg = (Int64)obj1;
                return +ggg;
            };
            return true;
        }
    
        if(type == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1) => {
                UInt64 ggg = (UInt64)obj1;
                return +ggg;
            };
            return true;
        }
    
        if(type == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1) => {
                Char ggg = (Char)obj1;
                return +ggg;
            };
            return true;
        }
    
        if(type == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1) => {
                Double ggg = (Double)obj1;
                return +ggg;
            };
            return true;
        }
    
        if(type == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1) => {
                Single ggg = (Single)obj1;
                return +ggg;
            };
            return true;
        }
    
        if(type == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1) => {
                Decimal ggg = (Decimal)obj1;
                return +ggg;
            };
            return true;
        }
    
        result = null;
        func = null;
        return false;
    }
    
    public static bool CheckOnesComplement(Type type, out Type result, out Func<object,object> func)
    {
    
        if(type == typeof(Byte))
        {
            result = typeof(System.Int32);
            func = (object obj1) => {
                Byte ggg = (Byte)obj1;
                return ~ggg;
            };
            return true;
        }
    
        if(type == typeof(SByte))
        {
            result = typeof(System.Int32);
            func = (object obj1) => {
                SByte ggg = (SByte)obj1;
                return ~ggg;
            };
            return true;
        }
    
        if(type == typeof(Int16))
        {
            result = typeof(System.Int32);
            func = (object obj1) => {
                Int16 ggg = (Int16)obj1;
                return ~ggg;
            };
            return true;
        }
    
        if(type == typeof(UInt16))
        {
            result = typeof(System.Int32);
            func = (object obj1) => {
                UInt16 ggg = (UInt16)obj1;
                return ~ggg;
            };
            return true;
        }
    
        if(type == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1) => {
                Int32 ggg = (Int32)obj1;
                return ~ggg;
            };
            return true;
        }
    
        if(type == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1) => {
                UInt32 ggg = (UInt32)obj1;
                return ~ggg;
            };
            return true;
        }
    
        if(type == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1) => {
                Int64 ggg = (Int64)obj1;
                return ~ggg;
            };
            return true;
        }
    
        if(type == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1) => {
                UInt64 ggg = (UInt64)obj1;
                return ~ggg;
            };
            return true;
        }
    
        if(type == typeof(Char))
        {
            result = typeof(System.Int32);
            func = (object obj1) => {
                Char ggg = (Char)obj1;
                return ~ggg;
            };
            return true;
        }
    
        result = null;
        func = null;
        return false;
    }
    
    public static bool CheckIncrement(Type type, out Type result, out Func<object,object> func)
    {
    
        if(type == typeof(Byte))
        {
            result = typeof(System.Byte);
            func = (object obj1) => {
                Byte ggg = (Byte)obj1;
                return ++ggg;
            };
            return true;
        }
    
        if(type == typeof(SByte))
        {
            result = typeof(System.SByte);
            func = (object obj1) => {
                SByte ggg = (SByte)obj1;
                return ++ggg;
            };
            return true;
        }
    
        if(type == typeof(Int16))
        {
            result = typeof(System.Int16);
            func = (object obj1) => {
                Int16 ggg = (Int16)obj1;
                return ++ggg;
            };
            return true;
        }
    
        if(type == typeof(UInt16))
        {
            result = typeof(System.UInt16);
            func = (object obj1) => {
                UInt16 ggg = (UInt16)obj1;
                return ++ggg;
            };
            return true;
        }
    
        if(type == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1) => {
                Int32 ggg = (Int32)obj1;
                return ++ggg;
            };
            return true;
        }
    
        if(type == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1) => {
                UInt32 ggg = (UInt32)obj1;
                return ++ggg;
            };
            return true;
        }
    
        if(type == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1) => {
                Int64 ggg = (Int64)obj1;
                return ++ggg;
            };
            return true;
        }
    
        if(type == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1) => {
                UInt64 ggg = (UInt64)obj1;
                return ++ggg;
            };
            return true;
        }
    
        if(type == typeof(Char))
        {
            result = typeof(System.Char);
            func = (object obj1) => {
                Char ggg = (Char)obj1;
                return ++ggg;
            };
            return true;
        }
    
        if(type == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1) => {
                Double ggg = (Double)obj1;
                return ++ggg;
            };
            return true;
        }
    
        if(type == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1) => {
                Single ggg = (Single)obj1;
                return ++ggg;
            };
            return true;
        }
    
        if(type == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1) => {
                Decimal ggg = (Decimal)obj1;
                return ++ggg;
            };
            return true;
        }
    
        result = null;
        func = null;
        return false;
    }
    
    public static bool CheckDecrement(Type type, out Type result, out Func<object,object> func)
    {
    
        if(type == typeof(Byte))
        {
            result = typeof(System.Byte);
            func = (object obj1) => {
                Byte ggg = (Byte)obj1;
                return --ggg;
            };
            return true;
        }
    
        if(type == typeof(SByte))
        {
            result = typeof(System.SByte);
            func = (object obj1) => {
                SByte ggg = (SByte)obj1;
                return --ggg;
            };
            return true;
        }
    
        if(type == typeof(Int16))
        {
            result = typeof(System.Int16);
            func = (object obj1) => {
                Int16 ggg = (Int16)obj1;
                return --ggg;
            };
            return true;
        }
    
        if(type == typeof(UInt16))
        {
            result = typeof(System.UInt16);
            func = (object obj1) => {
                UInt16 ggg = (UInt16)obj1;
                return --ggg;
            };
            return true;
        }
    
        if(type == typeof(Int32))
        {
            result = typeof(System.Int32);
            func = (object obj1) => {
                Int32 ggg = (Int32)obj1;
                return --ggg;
            };
            return true;
        }
    
        if(type == typeof(UInt32))
        {
            result = typeof(System.UInt32);
            func = (object obj1) => {
                UInt32 ggg = (UInt32)obj1;
                return --ggg;
            };
            return true;
        }
    
        if(type == typeof(Int64))
        {
            result = typeof(System.Int64);
            func = (object obj1) => {
                Int64 ggg = (Int64)obj1;
                return --ggg;
            };
            return true;
        }
    
        if(type == typeof(UInt64))
        {
            result = typeof(System.UInt64);
            func = (object obj1) => {
                UInt64 ggg = (UInt64)obj1;
                return --ggg;
            };
            return true;
        }
    
        if(type == typeof(Char))
        {
            result = typeof(System.Char);
            func = (object obj1) => {
                Char ggg = (Char)obj1;
                return --ggg;
            };
            return true;
        }
    
        if(type == typeof(Double))
        {
            result = typeof(System.Double);
            func = (object obj1) => {
                Double ggg = (Double)obj1;
                return --ggg;
            };
            return true;
        }
    
        if(type == typeof(Single))
        {
            result = typeof(System.Single);
            func = (object obj1) => {
                Single ggg = (Single)obj1;
                return --ggg;
            };
            return true;
        }
    
        if(type == typeof(Decimal))
        {
            result = typeof(System.Decimal);
            func = (object obj1) => {
                Decimal ggg = (Decimal)obj1;
                return --ggg;
            };
            return true;
        }
    
        result = null;
        func = null;
        return false;
    }
    

    }
}
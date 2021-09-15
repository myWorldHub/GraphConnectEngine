using System;
public class OperatorChecker
{
    public static bool TryEquality(object obj1, object obj2, out object result)
    {
        Type type1 = obj1.GetType();
        Type type2 = obj2.GetType();
    
        if(obj1 is Boolean && obj2 is Boolean)
        {
            result = (Boolean)obj1 == (Boolean)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Byte)
        {
            result = (Byte)obj1 == (Byte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is SByte)
        {
            result = (Byte)obj1 == (SByte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int16)
        {
            result = (Byte)obj1 == (Int16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt16)
        {
            result = (Byte)obj1 == (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int32)
        {
            result = (Byte)obj1 == (Int32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt32)
        {
            result = (Byte)obj1 == (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int64)
        {
            result = (Byte)obj1 == (Int64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt64)
        {
            result = (Byte)obj1 == (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Char)
        {
            result = (Byte)obj1 == (Char)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Double)
        {
            result = (Byte)obj1 == (Double)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Single)
        {
            result = (Byte)obj1 == (Single)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Decimal)
        {
            result = (Byte)obj1 == (Decimal)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Byte)
        {
            result = (SByte)obj1 == (Byte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is SByte)
        {
            result = (SByte)obj1 == (SByte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int16)
        {
            result = (SByte)obj1 == (Int16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt16)
        {
            result = (SByte)obj1 == (UInt16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int32)
        {
            result = (SByte)obj1 == (Int32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt32)
        {
            result = (SByte)obj1 == (UInt32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int64)
        {
            result = (SByte)obj1 == (Int64)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Char)
        {
            result = (SByte)obj1 == (Char)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Double)
        {
            result = (SByte)obj1 == (Double)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Single)
        {
            result = (SByte)obj1 == (Single)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Decimal)
        {
            result = (SByte)obj1 == (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Byte)
        {
            result = (Int16)obj1 == (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is SByte)
        {
            result = (Int16)obj1 == (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int16)
        {
            result = (Int16)obj1 == (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt16)
        {
            result = (Int16)obj1 == (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int32)
        {
            result = (Int16)obj1 == (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt32)
        {
            result = (Int16)obj1 == (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int64)
        {
            result = (Int16)obj1 == (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Char)
        {
            result = (Int16)obj1 == (Char)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Double)
        {
            result = (Int16)obj1 == (Double)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Single)
        {
            result = (Int16)obj1 == (Single)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Decimal)
        {
            result = (Int16)obj1 == (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Byte)
        {
            result = (UInt16)obj1 == (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is SByte)
        {
            result = (UInt16)obj1 == (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int16)
        {
            result = (UInt16)obj1 == (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt16)
        {
            result = (UInt16)obj1 == (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int32)
        {
            result = (UInt16)obj1 == (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt32)
        {
            result = (UInt16)obj1 == (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int64)
        {
            result = (UInt16)obj1 == (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt64)
        {
            result = (UInt16)obj1 == (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Char)
        {
            result = (UInt16)obj1 == (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Double)
        {
            result = (UInt16)obj1 == (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Single)
        {
            result = (UInt16)obj1 == (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Decimal)
        {
            result = (UInt16)obj1 == (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Byte)
        {
            result = (Int32)obj1 == (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is SByte)
        {
            result = (Int32)obj1 == (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int16)
        {
            result = (Int32)obj1 == (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt16)
        {
            result = (Int32)obj1 == (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int32)
        {
            result = (Int32)obj1 == (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt32)
        {
            result = (Int32)obj1 == (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int64)
        {
            result = (Int32)obj1 == (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Char)
        {
            result = (Int32)obj1 == (Char)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Double)
        {
            result = (Int32)obj1 == (Double)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Single)
        {
            result = (Int32)obj1 == (Single)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Decimal)
        {
            result = (Int32)obj1 == (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Byte)
        {
            result = (UInt32)obj1 == (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is SByte)
        {
            result = (UInt32)obj1 == (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int16)
        {
            result = (UInt32)obj1 == (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt16)
        {
            result = (UInt32)obj1 == (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int32)
        {
            result = (UInt32)obj1 == (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt32)
        {
            result = (UInt32)obj1 == (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int64)
        {
            result = (UInt32)obj1 == (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt64)
        {
            result = (UInt32)obj1 == (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Char)
        {
            result = (UInt32)obj1 == (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Double)
        {
            result = (UInt32)obj1 == (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Single)
        {
            result = (UInt32)obj1 == (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Decimal)
        {
            result = (UInt32)obj1 == (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Byte)
        {
            result = (Int64)obj1 == (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is SByte)
        {
            result = (Int64)obj1 == (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int16)
        {
            result = (Int64)obj1 == (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt16)
        {
            result = (Int64)obj1 == (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int32)
        {
            result = (Int64)obj1 == (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int64)
        {
            result = (Int64)obj1 == (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Char)
        {
            result = (Int64)obj1 == (Char)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Double)
        {
            result = (Int64)obj1 == (Double)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Single)
        {
            result = (Int64)obj1 == (Single)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Decimal)
        {
            result = (Int64)obj1 == (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Byte)
        {
            result = (UInt64)obj1 == (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt16)
        {
            result = (UInt64)obj1 == (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt32)
        {
            result = (UInt64)obj1 == (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt64)
        {
            result = (UInt64)obj1 == (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Char)
        {
            result = (UInt64)obj1 == (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Double)
        {
            result = (UInt64)obj1 == (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Single)
        {
            result = (UInt64)obj1 == (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Decimal)
        {
            result = (UInt64)obj1 == (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Byte)
        {
            result = (Char)obj1 == (Byte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is SByte)
        {
            result = (Char)obj1 == (SByte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int16)
        {
            result = (Char)obj1 == (Int16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt16)
        {
            result = (Char)obj1 == (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int32)
        {
            result = (Char)obj1 == (Int32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt32)
        {
            result = (Char)obj1 == (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int64)
        {
            result = (Char)obj1 == (Int64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt64)
        {
            result = (Char)obj1 == (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Char)
        {
            result = (Char)obj1 == (Char)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Double)
        {
            result = (Char)obj1 == (Double)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Single)
        {
            result = (Char)obj1 == (Single)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Decimal)
        {
            result = (Char)obj1 == (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Byte)
        {
            result = (Double)obj1 == (Byte)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is SByte)
        {
            result = (Double)obj1 == (SByte)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int16)
        {
            result = (Double)obj1 == (Int16)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt16)
        {
            result = (Double)obj1 == (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int32)
        {
            result = (Double)obj1 == (Int32)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt32)
        {
            result = (Double)obj1 == (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int64)
        {
            result = (Double)obj1 == (Int64)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt64)
        {
            result = (Double)obj1 == (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Char)
        {
            result = (Double)obj1 == (Char)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Double)
        {
            result = (Double)obj1 == (Double)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Single)
        {
            result = (Double)obj1 == (Single)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Byte)
        {
            result = (Single)obj1 == (Byte)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is SByte)
        {
            result = (Single)obj1 == (SByte)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int16)
        {
            result = (Single)obj1 == (Int16)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt16)
        {
            result = (Single)obj1 == (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int32)
        {
            result = (Single)obj1 == (Int32)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt32)
        {
            result = (Single)obj1 == (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int64)
        {
            result = (Single)obj1 == (Int64)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt64)
        {
            result = (Single)obj1 == (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Char)
        {
            result = (Single)obj1 == (Char)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Double)
        {
            result = (Single)obj1 == (Double)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Single)
        {
            result = (Single)obj1 == (Single)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Byte)
        {
            result = (Decimal)obj1 == (Byte)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is SByte)
        {
            result = (Decimal)obj1 == (SByte)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int16)
        {
            result = (Decimal)obj1 == (Int16)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt16)
        {
            result = (Decimal)obj1 == (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int32)
        {
            result = (Decimal)obj1 == (Int32)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt32)
        {
            result = (Decimal)obj1 == (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int64)
        {
            result = (Decimal)obj1 == (Int64)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt64)
        {
            result = (Decimal)obj1 == (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Char)
        {
            result = (Decimal)obj1 == (Char)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Decimal)
        {
            result = (Decimal)obj1 == (Decimal)obj2;
            return true;
        }
    
        if(obj1 is String && obj2 is String)
        {
            result = (String)obj1 == (String)obj2;
            return true;
        }
    
        result = null;
        return false;
    }
    
    public static bool TryInequality(object obj1, object obj2, out object result)
    {
        Type type1 = obj1.GetType();
        Type type2 = obj2.GetType();
    
        if(obj1 is Boolean && obj2 is Boolean)
        {
            result = (Boolean)obj1 != (Boolean)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Byte)
        {
            result = (Byte)obj1 != (Byte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is SByte)
        {
            result = (Byte)obj1 != (SByte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int16)
        {
            result = (Byte)obj1 != (Int16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt16)
        {
            result = (Byte)obj1 != (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int32)
        {
            result = (Byte)obj1 != (Int32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt32)
        {
            result = (Byte)obj1 != (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int64)
        {
            result = (Byte)obj1 != (Int64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt64)
        {
            result = (Byte)obj1 != (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Char)
        {
            result = (Byte)obj1 != (Char)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Double)
        {
            result = (Byte)obj1 != (Double)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Single)
        {
            result = (Byte)obj1 != (Single)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Decimal)
        {
            result = (Byte)obj1 != (Decimal)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Byte)
        {
            result = (SByte)obj1 != (Byte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is SByte)
        {
            result = (SByte)obj1 != (SByte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int16)
        {
            result = (SByte)obj1 != (Int16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt16)
        {
            result = (SByte)obj1 != (UInt16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int32)
        {
            result = (SByte)obj1 != (Int32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt32)
        {
            result = (SByte)obj1 != (UInt32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int64)
        {
            result = (SByte)obj1 != (Int64)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Char)
        {
            result = (SByte)obj1 != (Char)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Double)
        {
            result = (SByte)obj1 != (Double)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Single)
        {
            result = (SByte)obj1 != (Single)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Decimal)
        {
            result = (SByte)obj1 != (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Byte)
        {
            result = (Int16)obj1 != (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is SByte)
        {
            result = (Int16)obj1 != (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int16)
        {
            result = (Int16)obj1 != (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt16)
        {
            result = (Int16)obj1 != (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int32)
        {
            result = (Int16)obj1 != (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt32)
        {
            result = (Int16)obj1 != (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int64)
        {
            result = (Int16)obj1 != (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Char)
        {
            result = (Int16)obj1 != (Char)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Double)
        {
            result = (Int16)obj1 != (Double)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Single)
        {
            result = (Int16)obj1 != (Single)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Decimal)
        {
            result = (Int16)obj1 != (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Byte)
        {
            result = (UInt16)obj1 != (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is SByte)
        {
            result = (UInt16)obj1 != (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int16)
        {
            result = (UInt16)obj1 != (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt16)
        {
            result = (UInt16)obj1 != (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int32)
        {
            result = (UInt16)obj1 != (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt32)
        {
            result = (UInt16)obj1 != (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int64)
        {
            result = (UInt16)obj1 != (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt64)
        {
            result = (UInt16)obj1 != (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Char)
        {
            result = (UInt16)obj1 != (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Double)
        {
            result = (UInt16)obj1 != (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Single)
        {
            result = (UInt16)obj1 != (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Decimal)
        {
            result = (UInt16)obj1 != (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Byte)
        {
            result = (Int32)obj1 != (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is SByte)
        {
            result = (Int32)obj1 != (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int16)
        {
            result = (Int32)obj1 != (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt16)
        {
            result = (Int32)obj1 != (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int32)
        {
            result = (Int32)obj1 != (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt32)
        {
            result = (Int32)obj1 != (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int64)
        {
            result = (Int32)obj1 != (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Char)
        {
            result = (Int32)obj1 != (Char)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Double)
        {
            result = (Int32)obj1 != (Double)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Single)
        {
            result = (Int32)obj1 != (Single)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Decimal)
        {
            result = (Int32)obj1 != (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Byte)
        {
            result = (UInt32)obj1 != (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is SByte)
        {
            result = (UInt32)obj1 != (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int16)
        {
            result = (UInt32)obj1 != (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt16)
        {
            result = (UInt32)obj1 != (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int32)
        {
            result = (UInt32)obj1 != (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt32)
        {
            result = (UInt32)obj1 != (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int64)
        {
            result = (UInt32)obj1 != (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt64)
        {
            result = (UInt32)obj1 != (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Char)
        {
            result = (UInt32)obj1 != (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Double)
        {
            result = (UInt32)obj1 != (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Single)
        {
            result = (UInt32)obj1 != (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Decimal)
        {
            result = (UInt32)obj1 != (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Byte)
        {
            result = (Int64)obj1 != (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is SByte)
        {
            result = (Int64)obj1 != (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int16)
        {
            result = (Int64)obj1 != (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt16)
        {
            result = (Int64)obj1 != (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int32)
        {
            result = (Int64)obj1 != (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt32)
        {
            result = (Int64)obj1 != (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int64)
        {
            result = (Int64)obj1 != (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Char)
        {
            result = (Int64)obj1 != (Char)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Double)
        {
            result = (Int64)obj1 != (Double)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Single)
        {
            result = (Int64)obj1 != (Single)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Decimal)
        {
            result = (Int64)obj1 != (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Byte)
        {
            result = (UInt64)obj1 != (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt16)
        {
            result = (UInt64)obj1 != (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt32)
        {
            result = (UInt64)obj1 != (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt64)
        {
            result = (UInt64)obj1 != (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Char)
        {
            result = (UInt64)obj1 != (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Double)
        {
            result = (UInt64)obj1 != (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Single)
        {
            result = (UInt64)obj1 != (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Decimal)
        {
            result = (UInt64)obj1 != (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Byte)
        {
            result = (Char)obj1 != (Byte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is SByte)
        {
            result = (Char)obj1 != (SByte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int16)
        {
            result = (Char)obj1 != (Int16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt16)
        {
            result = (Char)obj1 != (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int32)
        {
            result = (Char)obj1 != (Int32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt32)
        {
            result = (Char)obj1 != (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int64)
        {
            result = (Char)obj1 != (Int64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt64)
        {
            result = (Char)obj1 != (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Char)
        {
            result = (Char)obj1 != (Char)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Double)
        {
            result = (Char)obj1 != (Double)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Single)
        {
            result = (Char)obj1 != (Single)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Decimal)
        {
            result = (Char)obj1 != (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Byte)
        {
            result = (Double)obj1 != (Byte)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is SByte)
        {
            result = (Double)obj1 != (SByte)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int16)
        {
            result = (Double)obj1 != (Int16)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt16)
        {
            result = (Double)obj1 != (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int32)
        {
            result = (Double)obj1 != (Int32)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt32)
        {
            result = (Double)obj1 != (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int64)
        {
            result = (Double)obj1 != (Int64)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt64)
        {
            result = (Double)obj1 != (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Char)
        {
            result = (Double)obj1 != (Char)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Double)
        {
            result = (Double)obj1 != (Double)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Single)
        {
            result = (Double)obj1 != (Single)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Byte)
        {
            result = (Single)obj1 != (Byte)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is SByte)
        {
            result = (Single)obj1 != (SByte)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int16)
        {
            result = (Single)obj1 != (Int16)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt16)
        {
            result = (Single)obj1 != (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int32)
        {
            result = (Single)obj1 != (Int32)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt32)
        {
            result = (Single)obj1 != (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int64)
        {
            result = (Single)obj1 != (Int64)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt64)
        {
            result = (Single)obj1 != (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Char)
        {
            result = (Single)obj1 != (Char)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Double)
        {
            result = (Single)obj1 != (Double)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Single)
        {
            result = (Single)obj1 != (Single)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Byte)
        {
            result = (Decimal)obj1 != (Byte)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is SByte)
        {
            result = (Decimal)obj1 != (SByte)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int16)
        {
            result = (Decimal)obj1 != (Int16)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt16)
        {
            result = (Decimal)obj1 != (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int32)
        {
            result = (Decimal)obj1 != (Int32)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt32)
        {
            result = (Decimal)obj1 != (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int64)
        {
            result = (Decimal)obj1 != (Int64)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt64)
        {
            result = (Decimal)obj1 != (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Char)
        {
            result = (Decimal)obj1 != (Char)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Decimal)
        {
            result = (Decimal)obj1 != (Decimal)obj2;
            return true;
        }
    
        if(obj1 is String && obj2 is String)
        {
            result = (String)obj1 != (String)obj2;
            return true;
        }
    
        result = null;
        return false;
    }
    
    public static bool TryGreaterThan(object obj1, object obj2, out object result)
    {
        Type type1 = obj1.GetType();
        Type type2 = obj2.GetType();
    
        if(obj1 is Byte && obj2 is Byte)
        {
            result = (Byte)obj1 > (Byte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is SByte)
        {
            result = (Byte)obj1 > (SByte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int16)
        {
            result = (Byte)obj1 > (Int16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt16)
        {
            result = (Byte)obj1 > (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int32)
        {
            result = (Byte)obj1 > (Int32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt32)
        {
            result = (Byte)obj1 > (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int64)
        {
            result = (Byte)obj1 > (Int64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt64)
        {
            result = (Byte)obj1 > (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Char)
        {
            result = (Byte)obj1 > (Char)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Double)
        {
            result = (Byte)obj1 > (Double)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Single)
        {
            result = (Byte)obj1 > (Single)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Decimal)
        {
            result = (Byte)obj1 > (Decimal)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Byte)
        {
            result = (SByte)obj1 > (Byte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is SByte)
        {
            result = (SByte)obj1 > (SByte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int16)
        {
            result = (SByte)obj1 > (Int16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt16)
        {
            result = (SByte)obj1 > (UInt16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int32)
        {
            result = (SByte)obj1 > (Int32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt32)
        {
            result = (SByte)obj1 > (UInt32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int64)
        {
            result = (SByte)obj1 > (Int64)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Char)
        {
            result = (SByte)obj1 > (Char)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Double)
        {
            result = (SByte)obj1 > (Double)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Single)
        {
            result = (SByte)obj1 > (Single)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Decimal)
        {
            result = (SByte)obj1 > (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Byte)
        {
            result = (Int16)obj1 > (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is SByte)
        {
            result = (Int16)obj1 > (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int16)
        {
            result = (Int16)obj1 > (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt16)
        {
            result = (Int16)obj1 > (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int32)
        {
            result = (Int16)obj1 > (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt32)
        {
            result = (Int16)obj1 > (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int64)
        {
            result = (Int16)obj1 > (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Char)
        {
            result = (Int16)obj1 > (Char)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Double)
        {
            result = (Int16)obj1 > (Double)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Single)
        {
            result = (Int16)obj1 > (Single)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Decimal)
        {
            result = (Int16)obj1 > (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Byte)
        {
            result = (UInt16)obj1 > (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is SByte)
        {
            result = (UInt16)obj1 > (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int16)
        {
            result = (UInt16)obj1 > (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt16)
        {
            result = (UInt16)obj1 > (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int32)
        {
            result = (UInt16)obj1 > (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt32)
        {
            result = (UInt16)obj1 > (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int64)
        {
            result = (UInt16)obj1 > (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt64)
        {
            result = (UInt16)obj1 > (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Char)
        {
            result = (UInt16)obj1 > (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Double)
        {
            result = (UInt16)obj1 > (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Single)
        {
            result = (UInt16)obj1 > (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Decimal)
        {
            result = (UInt16)obj1 > (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Byte)
        {
            result = (Int32)obj1 > (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is SByte)
        {
            result = (Int32)obj1 > (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int16)
        {
            result = (Int32)obj1 > (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt16)
        {
            result = (Int32)obj1 > (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int32)
        {
            result = (Int32)obj1 > (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt32)
        {
            result = (Int32)obj1 > (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int64)
        {
            result = (Int32)obj1 > (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Char)
        {
            result = (Int32)obj1 > (Char)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Double)
        {
            result = (Int32)obj1 > (Double)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Single)
        {
            result = (Int32)obj1 > (Single)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Decimal)
        {
            result = (Int32)obj1 > (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Byte)
        {
            result = (UInt32)obj1 > (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is SByte)
        {
            result = (UInt32)obj1 > (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int16)
        {
            result = (UInt32)obj1 > (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt16)
        {
            result = (UInt32)obj1 > (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int32)
        {
            result = (UInt32)obj1 > (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt32)
        {
            result = (UInt32)obj1 > (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int64)
        {
            result = (UInt32)obj1 > (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt64)
        {
            result = (UInt32)obj1 > (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Char)
        {
            result = (UInt32)obj1 > (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Double)
        {
            result = (UInt32)obj1 > (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Single)
        {
            result = (UInt32)obj1 > (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Decimal)
        {
            result = (UInt32)obj1 > (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Byte)
        {
            result = (Int64)obj1 > (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is SByte)
        {
            result = (Int64)obj1 > (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int16)
        {
            result = (Int64)obj1 > (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt16)
        {
            result = (Int64)obj1 > (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int32)
        {
            result = (Int64)obj1 > (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt32)
        {
            result = (Int64)obj1 > (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int64)
        {
            result = (Int64)obj1 > (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Char)
        {
            result = (Int64)obj1 > (Char)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Double)
        {
            result = (Int64)obj1 > (Double)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Single)
        {
            result = (Int64)obj1 > (Single)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Decimal)
        {
            result = (Int64)obj1 > (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Byte)
        {
            result = (UInt64)obj1 > (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt16)
        {
            result = (UInt64)obj1 > (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt32)
        {
            result = (UInt64)obj1 > (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt64)
        {
            result = (UInt64)obj1 > (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Char)
        {
            result = (UInt64)obj1 > (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Double)
        {
            result = (UInt64)obj1 > (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Single)
        {
            result = (UInt64)obj1 > (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Decimal)
        {
            result = (UInt64)obj1 > (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Byte)
        {
            result = (Char)obj1 > (Byte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is SByte)
        {
            result = (Char)obj1 > (SByte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int16)
        {
            result = (Char)obj1 > (Int16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt16)
        {
            result = (Char)obj1 > (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int32)
        {
            result = (Char)obj1 > (Int32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt32)
        {
            result = (Char)obj1 > (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int64)
        {
            result = (Char)obj1 > (Int64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt64)
        {
            result = (Char)obj1 > (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Char)
        {
            result = (Char)obj1 > (Char)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Double)
        {
            result = (Char)obj1 > (Double)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Single)
        {
            result = (Char)obj1 > (Single)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Decimal)
        {
            result = (Char)obj1 > (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Byte)
        {
            result = (Double)obj1 > (Byte)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is SByte)
        {
            result = (Double)obj1 > (SByte)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int16)
        {
            result = (Double)obj1 > (Int16)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt16)
        {
            result = (Double)obj1 > (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int32)
        {
            result = (Double)obj1 > (Int32)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt32)
        {
            result = (Double)obj1 > (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int64)
        {
            result = (Double)obj1 > (Int64)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt64)
        {
            result = (Double)obj1 > (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Char)
        {
            result = (Double)obj1 > (Char)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Double)
        {
            result = (Double)obj1 > (Double)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Single)
        {
            result = (Double)obj1 > (Single)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Byte)
        {
            result = (Single)obj1 > (Byte)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is SByte)
        {
            result = (Single)obj1 > (SByte)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int16)
        {
            result = (Single)obj1 > (Int16)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt16)
        {
            result = (Single)obj1 > (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int32)
        {
            result = (Single)obj1 > (Int32)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt32)
        {
            result = (Single)obj1 > (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int64)
        {
            result = (Single)obj1 > (Int64)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt64)
        {
            result = (Single)obj1 > (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Char)
        {
            result = (Single)obj1 > (Char)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Double)
        {
            result = (Single)obj1 > (Double)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Single)
        {
            result = (Single)obj1 > (Single)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Byte)
        {
            result = (Decimal)obj1 > (Byte)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is SByte)
        {
            result = (Decimal)obj1 > (SByte)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int16)
        {
            result = (Decimal)obj1 > (Int16)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt16)
        {
            result = (Decimal)obj1 > (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int32)
        {
            result = (Decimal)obj1 > (Int32)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt32)
        {
            result = (Decimal)obj1 > (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int64)
        {
            result = (Decimal)obj1 > (Int64)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt64)
        {
            result = (Decimal)obj1 > (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Char)
        {
            result = (Decimal)obj1 > (Char)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Decimal)
        {
            result = (Decimal)obj1 > (Decimal)obj2;
            return true;
        }
    
        result = null;
        return false;
    }
    
    public static bool TryLessThan(object obj1, object obj2, out object result)
    {
        Type type1 = obj1.GetType();
        Type type2 = obj2.GetType();
    
        if(obj1 is Byte && obj2 is Byte)
        {
            result = (Byte)obj1 < (Byte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is SByte)
        {
            result = (Byte)obj1 < (SByte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int16)
        {
            result = (Byte)obj1 < (Int16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt16)
        {
            result = (Byte)obj1 < (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int32)
        {
            result = (Byte)obj1 < (Int32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt32)
        {
            result = (Byte)obj1 < (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int64)
        {
            result = (Byte)obj1 < (Int64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt64)
        {
            result = (Byte)obj1 < (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Char)
        {
            result = (Byte)obj1 < (Char)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Double)
        {
            result = (Byte)obj1 < (Double)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Single)
        {
            result = (Byte)obj1 < (Single)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Decimal)
        {
            result = (Byte)obj1 < (Decimal)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Byte)
        {
            result = (SByte)obj1 < (Byte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is SByte)
        {
            result = (SByte)obj1 < (SByte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int16)
        {
            result = (SByte)obj1 < (Int16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt16)
        {
            result = (SByte)obj1 < (UInt16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int32)
        {
            result = (SByte)obj1 < (Int32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt32)
        {
            result = (SByte)obj1 < (UInt32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int64)
        {
            result = (SByte)obj1 < (Int64)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Char)
        {
            result = (SByte)obj1 < (Char)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Double)
        {
            result = (SByte)obj1 < (Double)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Single)
        {
            result = (SByte)obj1 < (Single)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Decimal)
        {
            result = (SByte)obj1 < (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Byte)
        {
            result = (Int16)obj1 < (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is SByte)
        {
            result = (Int16)obj1 < (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int16)
        {
            result = (Int16)obj1 < (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt16)
        {
            result = (Int16)obj1 < (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int32)
        {
            result = (Int16)obj1 < (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt32)
        {
            result = (Int16)obj1 < (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int64)
        {
            result = (Int16)obj1 < (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Char)
        {
            result = (Int16)obj1 < (Char)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Double)
        {
            result = (Int16)obj1 < (Double)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Single)
        {
            result = (Int16)obj1 < (Single)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Decimal)
        {
            result = (Int16)obj1 < (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Byte)
        {
            result = (UInt16)obj1 < (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is SByte)
        {
            result = (UInt16)obj1 < (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int16)
        {
            result = (UInt16)obj1 < (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt16)
        {
            result = (UInt16)obj1 < (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int32)
        {
            result = (UInt16)obj1 < (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt32)
        {
            result = (UInt16)obj1 < (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int64)
        {
            result = (UInt16)obj1 < (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt64)
        {
            result = (UInt16)obj1 < (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Char)
        {
            result = (UInt16)obj1 < (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Double)
        {
            result = (UInt16)obj1 < (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Single)
        {
            result = (UInt16)obj1 < (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Decimal)
        {
            result = (UInt16)obj1 < (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Byte)
        {
            result = (Int32)obj1 < (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is SByte)
        {
            result = (Int32)obj1 < (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int16)
        {
            result = (Int32)obj1 < (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt16)
        {
            result = (Int32)obj1 < (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int32)
        {
            result = (Int32)obj1 < (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt32)
        {
            result = (Int32)obj1 < (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int64)
        {
            result = (Int32)obj1 < (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Char)
        {
            result = (Int32)obj1 < (Char)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Double)
        {
            result = (Int32)obj1 < (Double)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Single)
        {
            result = (Int32)obj1 < (Single)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Decimal)
        {
            result = (Int32)obj1 < (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Byte)
        {
            result = (UInt32)obj1 < (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is SByte)
        {
            result = (UInt32)obj1 < (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int16)
        {
            result = (UInt32)obj1 < (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt16)
        {
            result = (UInt32)obj1 < (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int32)
        {
            result = (UInt32)obj1 < (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt32)
        {
            result = (UInt32)obj1 < (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int64)
        {
            result = (UInt32)obj1 < (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt64)
        {
            result = (UInt32)obj1 < (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Char)
        {
            result = (UInt32)obj1 < (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Double)
        {
            result = (UInt32)obj1 < (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Single)
        {
            result = (UInt32)obj1 < (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Decimal)
        {
            result = (UInt32)obj1 < (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Byte)
        {
            result = (Int64)obj1 < (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is SByte)
        {
            result = (Int64)obj1 < (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int16)
        {
            result = (Int64)obj1 < (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt16)
        {
            result = (Int64)obj1 < (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int32)
        {
            result = (Int64)obj1 < (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt32)
        {
            result = (Int64)obj1 < (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int64)
        {
            result = (Int64)obj1 < (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Char)
        {
            result = (Int64)obj1 < (Char)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Double)
        {
            result = (Int64)obj1 < (Double)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Single)
        {
            result = (Int64)obj1 < (Single)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Decimal)
        {
            result = (Int64)obj1 < (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Byte)
        {
            result = (UInt64)obj1 < (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt16)
        {
            result = (UInt64)obj1 < (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt32)
        {
            result = (UInt64)obj1 < (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt64)
        {
            result = (UInt64)obj1 < (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Char)
        {
            result = (UInt64)obj1 < (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Double)
        {
            result = (UInt64)obj1 < (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Single)
        {
            result = (UInt64)obj1 < (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Decimal)
        {
            result = (UInt64)obj1 < (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Byte)
        {
            result = (Char)obj1 < (Byte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is SByte)
        {
            result = (Char)obj1 < (SByte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int16)
        {
            result = (Char)obj1 < (Int16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt16)
        {
            result = (Char)obj1 < (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int32)
        {
            result = (Char)obj1 < (Int32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt32)
        {
            result = (Char)obj1 < (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int64)
        {
            result = (Char)obj1 < (Int64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt64)
        {
            result = (Char)obj1 < (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Char)
        {
            result = (Char)obj1 < (Char)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Double)
        {
            result = (Char)obj1 < (Double)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Single)
        {
            result = (Char)obj1 < (Single)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Decimal)
        {
            result = (Char)obj1 < (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Byte)
        {
            result = (Double)obj1 < (Byte)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is SByte)
        {
            result = (Double)obj1 < (SByte)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int16)
        {
            result = (Double)obj1 < (Int16)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt16)
        {
            result = (Double)obj1 < (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int32)
        {
            result = (Double)obj1 < (Int32)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt32)
        {
            result = (Double)obj1 < (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int64)
        {
            result = (Double)obj1 < (Int64)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt64)
        {
            result = (Double)obj1 < (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Char)
        {
            result = (Double)obj1 < (Char)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Double)
        {
            result = (Double)obj1 < (Double)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Single)
        {
            result = (Double)obj1 < (Single)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Byte)
        {
            result = (Single)obj1 < (Byte)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is SByte)
        {
            result = (Single)obj1 < (SByte)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int16)
        {
            result = (Single)obj1 < (Int16)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt16)
        {
            result = (Single)obj1 < (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int32)
        {
            result = (Single)obj1 < (Int32)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt32)
        {
            result = (Single)obj1 < (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int64)
        {
            result = (Single)obj1 < (Int64)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt64)
        {
            result = (Single)obj1 < (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Char)
        {
            result = (Single)obj1 < (Char)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Double)
        {
            result = (Single)obj1 < (Double)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Single)
        {
            result = (Single)obj1 < (Single)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Byte)
        {
            result = (Decimal)obj1 < (Byte)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is SByte)
        {
            result = (Decimal)obj1 < (SByte)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int16)
        {
            result = (Decimal)obj1 < (Int16)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt16)
        {
            result = (Decimal)obj1 < (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int32)
        {
            result = (Decimal)obj1 < (Int32)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt32)
        {
            result = (Decimal)obj1 < (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int64)
        {
            result = (Decimal)obj1 < (Int64)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt64)
        {
            result = (Decimal)obj1 < (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Char)
        {
            result = (Decimal)obj1 < (Char)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Decimal)
        {
            result = (Decimal)obj1 < (Decimal)obj2;
            return true;
        }
    
        result = null;
        return false;
    }
    
    public static bool TryGreaterThanOrEqual(object obj1, object obj2, out object result)
    {
        Type type1 = obj1.GetType();
        Type type2 = obj2.GetType();
    
        if(obj1 is Byte && obj2 is Byte)
        {
            result = (Byte)obj1 >= (Byte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is SByte)
        {
            result = (Byte)obj1 >= (SByte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int16)
        {
            result = (Byte)obj1 >= (Int16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt16)
        {
            result = (Byte)obj1 >= (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int32)
        {
            result = (Byte)obj1 >= (Int32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt32)
        {
            result = (Byte)obj1 >= (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int64)
        {
            result = (Byte)obj1 >= (Int64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt64)
        {
            result = (Byte)obj1 >= (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Char)
        {
            result = (Byte)obj1 >= (Char)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Double)
        {
            result = (Byte)obj1 >= (Double)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Single)
        {
            result = (Byte)obj1 >= (Single)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Decimal)
        {
            result = (Byte)obj1 >= (Decimal)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Byte)
        {
            result = (SByte)obj1 >= (Byte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is SByte)
        {
            result = (SByte)obj1 >= (SByte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int16)
        {
            result = (SByte)obj1 >= (Int16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt16)
        {
            result = (SByte)obj1 >= (UInt16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int32)
        {
            result = (SByte)obj1 >= (Int32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt32)
        {
            result = (SByte)obj1 >= (UInt32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int64)
        {
            result = (SByte)obj1 >= (Int64)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Char)
        {
            result = (SByte)obj1 >= (Char)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Double)
        {
            result = (SByte)obj1 >= (Double)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Single)
        {
            result = (SByte)obj1 >= (Single)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Decimal)
        {
            result = (SByte)obj1 >= (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Byte)
        {
            result = (Int16)obj1 >= (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is SByte)
        {
            result = (Int16)obj1 >= (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int16)
        {
            result = (Int16)obj1 >= (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt16)
        {
            result = (Int16)obj1 >= (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int32)
        {
            result = (Int16)obj1 >= (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt32)
        {
            result = (Int16)obj1 >= (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int64)
        {
            result = (Int16)obj1 >= (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Char)
        {
            result = (Int16)obj1 >= (Char)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Double)
        {
            result = (Int16)obj1 >= (Double)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Single)
        {
            result = (Int16)obj1 >= (Single)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Decimal)
        {
            result = (Int16)obj1 >= (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Byte)
        {
            result = (UInt16)obj1 >= (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is SByte)
        {
            result = (UInt16)obj1 >= (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int16)
        {
            result = (UInt16)obj1 >= (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt16)
        {
            result = (UInt16)obj1 >= (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int32)
        {
            result = (UInt16)obj1 >= (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt32)
        {
            result = (UInt16)obj1 >= (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int64)
        {
            result = (UInt16)obj1 >= (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt64)
        {
            result = (UInt16)obj1 >= (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Char)
        {
            result = (UInt16)obj1 >= (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Double)
        {
            result = (UInt16)obj1 >= (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Single)
        {
            result = (UInt16)obj1 >= (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Decimal)
        {
            result = (UInt16)obj1 >= (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Byte)
        {
            result = (Int32)obj1 >= (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is SByte)
        {
            result = (Int32)obj1 >= (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int16)
        {
            result = (Int32)obj1 >= (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt16)
        {
            result = (Int32)obj1 >= (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int32)
        {
            result = (Int32)obj1 >= (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt32)
        {
            result = (Int32)obj1 >= (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int64)
        {
            result = (Int32)obj1 >= (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Char)
        {
            result = (Int32)obj1 >= (Char)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Double)
        {
            result = (Int32)obj1 >= (Double)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Single)
        {
            result = (Int32)obj1 >= (Single)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Decimal)
        {
            result = (Int32)obj1 >= (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Byte)
        {
            result = (UInt32)obj1 >= (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is SByte)
        {
            result = (UInt32)obj1 >= (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int16)
        {
            result = (UInt32)obj1 >= (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt16)
        {
            result = (UInt32)obj1 >= (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int32)
        {
            result = (UInt32)obj1 >= (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt32)
        {
            result = (UInt32)obj1 >= (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int64)
        {
            result = (UInt32)obj1 >= (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt64)
        {
            result = (UInt32)obj1 >= (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Char)
        {
            result = (UInt32)obj1 >= (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Double)
        {
            result = (UInt32)obj1 >= (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Single)
        {
            result = (UInt32)obj1 >= (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Decimal)
        {
            result = (UInt32)obj1 >= (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Byte)
        {
            result = (Int64)obj1 >= (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is SByte)
        {
            result = (Int64)obj1 >= (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int16)
        {
            result = (Int64)obj1 >= (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt16)
        {
            result = (Int64)obj1 >= (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int32)
        {
            result = (Int64)obj1 >= (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt32)
        {
            result = (Int64)obj1 >= (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int64)
        {
            result = (Int64)obj1 >= (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Char)
        {
            result = (Int64)obj1 >= (Char)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Double)
        {
            result = (Int64)obj1 >= (Double)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Single)
        {
            result = (Int64)obj1 >= (Single)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Decimal)
        {
            result = (Int64)obj1 >= (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Byte)
        {
            result = (UInt64)obj1 >= (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt16)
        {
            result = (UInt64)obj1 >= (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt32)
        {
            result = (UInt64)obj1 >= (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt64)
        {
            result = (UInt64)obj1 >= (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Char)
        {
            result = (UInt64)obj1 >= (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Double)
        {
            result = (UInt64)obj1 >= (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Single)
        {
            result = (UInt64)obj1 >= (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Decimal)
        {
            result = (UInt64)obj1 >= (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Byte)
        {
            result = (Char)obj1 >= (Byte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is SByte)
        {
            result = (Char)obj1 >= (SByte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int16)
        {
            result = (Char)obj1 >= (Int16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt16)
        {
            result = (Char)obj1 >= (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int32)
        {
            result = (Char)obj1 >= (Int32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt32)
        {
            result = (Char)obj1 >= (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int64)
        {
            result = (Char)obj1 >= (Int64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt64)
        {
            result = (Char)obj1 >= (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Char)
        {
            result = (Char)obj1 >= (Char)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Double)
        {
            result = (Char)obj1 >= (Double)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Single)
        {
            result = (Char)obj1 >= (Single)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Decimal)
        {
            result = (Char)obj1 >= (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Byte)
        {
            result = (Double)obj1 >= (Byte)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is SByte)
        {
            result = (Double)obj1 >= (SByte)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int16)
        {
            result = (Double)obj1 >= (Int16)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt16)
        {
            result = (Double)obj1 >= (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int32)
        {
            result = (Double)obj1 >= (Int32)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt32)
        {
            result = (Double)obj1 >= (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int64)
        {
            result = (Double)obj1 >= (Int64)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt64)
        {
            result = (Double)obj1 >= (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Char)
        {
            result = (Double)obj1 >= (Char)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Double)
        {
            result = (Double)obj1 >= (Double)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Single)
        {
            result = (Double)obj1 >= (Single)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Byte)
        {
            result = (Single)obj1 >= (Byte)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is SByte)
        {
            result = (Single)obj1 >= (SByte)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int16)
        {
            result = (Single)obj1 >= (Int16)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt16)
        {
            result = (Single)obj1 >= (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int32)
        {
            result = (Single)obj1 >= (Int32)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt32)
        {
            result = (Single)obj1 >= (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int64)
        {
            result = (Single)obj1 >= (Int64)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt64)
        {
            result = (Single)obj1 >= (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Char)
        {
            result = (Single)obj1 >= (Char)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Double)
        {
            result = (Single)obj1 >= (Double)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Single)
        {
            result = (Single)obj1 >= (Single)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Byte)
        {
            result = (Decimal)obj1 >= (Byte)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is SByte)
        {
            result = (Decimal)obj1 >= (SByte)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int16)
        {
            result = (Decimal)obj1 >= (Int16)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt16)
        {
            result = (Decimal)obj1 >= (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int32)
        {
            result = (Decimal)obj1 >= (Int32)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt32)
        {
            result = (Decimal)obj1 >= (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int64)
        {
            result = (Decimal)obj1 >= (Int64)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt64)
        {
            result = (Decimal)obj1 >= (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Char)
        {
            result = (Decimal)obj1 >= (Char)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Decimal)
        {
            result = (Decimal)obj1 >= (Decimal)obj2;
            return true;
        }
    
        result = null;
        return false;
    }
    
    public static bool TryLessThanOrEqual(object obj1, object obj2, out object result)
    {
        Type type1 = obj1.GetType();
        Type type2 = obj2.GetType();
    
        if(obj1 is Byte && obj2 is Byte)
        {
            result = (Byte)obj1 <= (Byte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is SByte)
        {
            result = (Byte)obj1 <= (SByte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int16)
        {
            result = (Byte)obj1 <= (Int16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt16)
        {
            result = (Byte)obj1 <= (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int32)
        {
            result = (Byte)obj1 <= (Int32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt32)
        {
            result = (Byte)obj1 <= (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int64)
        {
            result = (Byte)obj1 <= (Int64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt64)
        {
            result = (Byte)obj1 <= (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Char)
        {
            result = (Byte)obj1 <= (Char)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Double)
        {
            result = (Byte)obj1 <= (Double)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Single)
        {
            result = (Byte)obj1 <= (Single)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Decimal)
        {
            result = (Byte)obj1 <= (Decimal)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Byte)
        {
            result = (SByte)obj1 <= (Byte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is SByte)
        {
            result = (SByte)obj1 <= (SByte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int16)
        {
            result = (SByte)obj1 <= (Int16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt16)
        {
            result = (SByte)obj1 <= (UInt16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int32)
        {
            result = (SByte)obj1 <= (Int32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt32)
        {
            result = (SByte)obj1 <= (UInt32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int64)
        {
            result = (SByte)obj1 <= (Int64)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Char)
        {
            result = (SByte)obj1 <= (Char)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Double)
        {
            result = (SByte)obj1 <= (Double)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Single)
        {
            result = (SByte)obj1 <= (Single)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Decimal)
        {
            result = (SByte)obj1 <= (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Byte)
        {
            result = (Int16)obj1 <= (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is SByte)
        {
            result = (Int16)obj1 <= (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int16)
        {
            result = (Int16)obj1 <= (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt16)
        {
            result = (Int16)obj1 <= (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int32)
        {
            result = (Int16)obj1 <= (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt32)
        {
            result = (Int16)obj1 <= (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int64)
        {
            result = (Int16)obj1 <= (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Char)
        {
            result = (Int16)obj1 <= (Char)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Double)
        {
            result = (Int16)obj1 <= (Double)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Single)
        {
            result = (Int16)obj1 <= (Single)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Decimal)
        {
            result = (Int16)obj1 <= (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Byte)
        {
            result = (UInt16)obj1 <= (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is SByte)
        {
            result = (UInt16)obj1 <= (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int16)
        {
            result = (UInt16)obj1 <= (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt16)
        {
            result = (UInt16)obj1 <= (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int32)
        {
            result = (UInt16)obj1 <= (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt32)
        {
            result = (UInt16)obj1 <= (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int64)
        {
            result = (UInt16)obj1 <= (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt64)
        {
            result = (UInt16)obj1 <= (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Char)
        {
            result = (UInt16)obj1 <= (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Double)
        {
            result = (UInt16)obj1 <= (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Single)
        {
            result = (UInt16)obj1 <= (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Decimal)
        {
            result = (UInt16)obj1 <= (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Byte)
        {
            result = (Int32)obj1 <= (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is SByte)
        {
            result = (Int32)obj1 <= (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int16)
        {
            result = (Int32)obj1 <= (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt16)
        {
            result = (Int32)obj1 <= (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int32)
        {
            result = (Int32)obj1 <= (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt32)
        {
            result = (Int32)obj1 <= (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int64)
        {
            result = (Int32)obj1 <= (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Char)
        {
            result = (Int32)obj1 <= (Char)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Double)
        {
            result = (Int32)obj1 <= (Double)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Single)
        {
            result = (Int32)obj1 <= (Single)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Decimal)
        {
            result = (Int32)obj1 <= (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Byte)
        {
            result = (UInt32)obj1 <= (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is SByte)
        {
            result = (UInt32)obj1 <= (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int16)
        {
            result = (UInt32)obj1 <= (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt16)
        {
            result = (UInt32)obj1 <= (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int32)
        {
            result = (UInt32)obj1 <= (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt32)
        {
            result = (UInt32)obj1 <= (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int64)
        {
            result = (UInt32)obj1 <= (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt64)
        {
            result = (UInt32)obj1 <= (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Char)
        {
            result = (UInt32)obj1 <= (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Double)
        {
            result = (UInt32)obj1 <= (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Single)
        {
            result = (UInt32)obj1 <= (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Decimal)
        {
            result = (UInt32)obj1 <= (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Byte)
        {
            result = (Int64)obj1 <= (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is SByte)
        {
            result = (Int64)obj1 <= (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int16)
        {
            result = (Int64)obj1 <= (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt16)
        {
            result = (Int64)obj1 <= (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int32)
        {
            result = (Int64)obj1 <= (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt32)
        {
            result = (Int64)obj1 <= (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int64)
        {
            result = (Int64)obj1 <= (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Char)
        {
            result = (Int64)obj1 <= (Char)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Double)
        {
            result = (Int64)obj1 <= (Double)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Single)
        {
            result = (Int64)obj1 <= (Single)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Decimal)
        {
            result = (Int64)obj1 <= (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Byte)
        {
            result = (UInt64)obj1 <= (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt16)
        {
            result = (UInt64)obj1 <= (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt32)
        {
            result = (UInt64)obj1 <= (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt64)
        {
            result = (UInt64)obj1 <= (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Char)
        {
            result = (UInt64)obj1 <= (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Double)
        {
            result = (UInt64)obj1 <= (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Single)
        {
            result = (UInt64)obj1 <= (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Decimal)
        {
            result = (UInt64)obj1 <= (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Byte)
        {
            result = (Char)obj1 <= (Byte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is SByte)
        {
            result = (Char)obj1 <= (SByte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int16)
        {
            result = (Char)obj1 <= (Int16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt16)
        {
            result = (Char)obj1 <= (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int32)
        {
            result = (Char)obj1 <= (Int32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt32)
        {
            result = (Char)obj1 <= (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int64)
        {
            result = (Char)obj1 <= (Int64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt64)
        {
            result = (Char)obj1 <= (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Char)
        {
            result = (Char)obj1 <= (Char)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Double)
        {
            result = (Char)obj1 <= (Double)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Single)
        {
            result = (Char)obj1 <= (Single)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Decimal)
        {
            result = (Char)obj1 <= (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Byte)
        {
            result = (Double)obj1 <= (Byte)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is SByte)
        {
            result = (Double)obj1 <= (SByte)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int16)
        {
            result = (Double)obj1 <= (Int16)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt16)
        {
            result = (Double)obj1 <= (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int32)
        {
            result = (Double)obj1 <= (Int32)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt32)
        {
            result = (Double)obj1 <= (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int64)
        {
            result = (Double)obj1 <= (Int64)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt64)
        {
            result = (Double)obj1 <= (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Char)
        {
            result = (Double)obj1 <= (Char)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Double)
        {
            result = (Double)obj1 <= (Double)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Single)
        {
            result = (Double)obj1 <= (Single)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Byte)
        {
            result = (Single)obj1 <= (Byte)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is SByte)
        {
            result = (Single)obj1 <= (SByte)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int16)
        {
            result = (Single)obj1 <= (Int16)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt16)
        {
            result = (Single)obj1 <= (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int32)
        {
            result = (Single)obj1 <= (Int32)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt32)
        {
            result = (Single)obj1 <= (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int64)
        {
            result = (Single)obj1 <= (Int64)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt64)
        {
            result = (Single)obj1 <= (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Char)
        {
            result = (Single)obj1 <= (Char)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Double)
        {
            result = (Single)obj1 <= (Double)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Single)
        {
            result = (Single)obj1 <= (Single)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Byte)
        {
            result = (Decimal)obj1 <= (Byte)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is SByte)
        {
            result = (Decimal)obj1 <= (SByte)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int16)
        {
            result = (Decimal)obj1 <= (Int16)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt16)
        {
            result = (Decimal)obj1 <= (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int32)
        {
            result = (Decimal)obj1 <= (Int32)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt32)
        {
            result = (Decimal)obj1 <= (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int64)
        {
            result = (Decimal)obj1 <= (Int64)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt64)
        {
            result = (Decimal)obj1 <= (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Char)
        {
            result = (Decimal)obj1 <= (Char)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Decimal)
        {
            result = (Decimal)obj1 <= (Decimal)obj2;
            return true;
        }
    
        result = null;
        return false;
    }
    
    public static bool TryBitwiseAnd(object obj1, object obj2, out object result)
    {
        Type type1 = obj1.GetType();
        Type type2 = obj2.GetType();
    
        if(obj1 is Boolean && obj2 is Boolean)
        {
            result = (Boolean)obj1 & (Boolean)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Byte)
        {
            result = (Byte)obj1 & (Byte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is SByte)
        {
            result = (Byte)obj1 & (SByte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int16)
        {
            result = (Byte)obj1 & (Int16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt16)
        {
            result = (Byte)obj1 & (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int32)
        {
            result = (Byte)obj1 & (Int32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt32)
        {
            result = (Byte)obj1 & (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int64)
        {
            result = (Byte)obj1 & (Int64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt64)
        {
            result = (Byte)obj1 & (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Char)
        {
            result = (Byte)obj1 & (Char)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Byte)
        {
            result = (SByte)obj1 & (Byte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is SByte)
        {
            result = (SByte)obj1 & (SByte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int16)
        {
            result = (SByte)obj1 & (Int16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt16)
        {
            result = (SByte)obj1 & (UInt16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int32)
        {
            result = (SByte)obj1 & (Int32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt32)
        {
            result = (SByte)obj1 & (UInt32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int64)
        {
            result = (SByte)obj1 & (Int64)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Char)
        {
            result = (SByte)obj1 & (Char)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Byte)
        {
            result = (Int16)obj1 & (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is SByte)
        {
            result = (Int16)obj1 & (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int16)
        {
            result = (Int16)obj1 & (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt16)
        {
            result = (Int16)obj1 & (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int32)
        {
            result = (Int16)obj1 & (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt32)
        {
            result = (Int16)obj1 & (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int64)
        {
            result = (Int16)obj1 & (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Char)
        {
            result = (Int16)obj1 & (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Byte)
        {
            result = (UInt16)obj1 & (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is SByte)
        {
            result = (UInt16)obj1 & (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int16)
        {
            result = (UInt16)obj1 & (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt16)
        {
            result = (UInt16)obj1 & (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int32)
        {
            result = (UInt16)obj1 & (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt32)
        {
            result = (UInt16)obj1 & (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int64)
        {
            result = (UInt16)obj1 & (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt64)
        {
            result = (UInt16)obj1 & (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Char)
        {
            result = (UInt16)obj1 & (Char)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Byte)
        {
            result = (Int32)obj1 & (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is SByte)
        {
            result = (Int32)obj1 & (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int16)
        {
            result = (Int32)obj1 & (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt16)
        {
            result = (Int32)obj1 & (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int32)
        {
            result = (Int32)obj1 & (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt32)
        {
            result = (Int32)obj1 & (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int64)
        {
            result = (Int32)obj1 & (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Char)
        {
            result = (Int32)obj1 & (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Byte)
        {
            result = (UInt32)obj1 & (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is SByte)
        {
            result = (UInt32)obj1 & (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int16)
        {
            result = (UInt32)obj1 & (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt16)
        {
            result = (UInt32)obj1 & (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int32)
        {
            result = (UInt32)obj1 & (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt32)
        {
            result = (UInt32)obj1 & (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int64)
        {
            result = (UInt32)obj1 & (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt64)
        {
            result = (UInt32)obj1 & (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Char)
        {
            result = (UInt32)obj1 & (Char)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Byte)
        {
            result = (Int64)obj1 & (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is SByte)
        {
            result = (Int64)obj1 & (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int16)
        {
            result = (Int64)obj1 & (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt16)
        {
            result = (Int64)obj1 & (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int32)
        {
            result = (Int64)obj1 & (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt32)
        {
            result = (Int64)obj1 & (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int64)
        {
            result = (Int64)obj1 & (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Char)
        {
            result = (Int64)obj1 & (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Byte)
        {
            result = (UInt64)obj1 & (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt16)
        {
            result = (UInt64)obj1 & (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt32)
        {
            result = (UInt64)obj1 & (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt64)
        {
            result = (UInt64)obj1 & (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Char)
        {
            result = (UInt64)obj1 & (Char)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Byte)
        {
            result = (Char)obj1 & (Byte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is SByte)
        {
            result = (Char)obj1 & (SByte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int16)
        {
            result = (Char)obj1 & (Int16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt16)
        {
            result = (Char)obj1 & (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int32)
        {
            result = (Char)obj1 & (Int32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt32)
        {
            result = (Char)obj1 & (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int64)
        {
            result = (Char)obj1 & (Int64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt64)
        {
            result = (Char)obj1 & (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Char)
        {
            result = (Char)obj1 & (Char)obj2;
            return true;
        }
    
        result = null;
        return false;
    }
    
    public static bool TryBitwiseOr(object obj1, object obj2, out object result)
    {
        Type type1 = obj1.GetType();
        Type type2 = obj2.GetType();
    
        if(obj1 is Boolean && obj2 is Boolean)
        {
            result = (Boolean)obj1 | (Boolean)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Byte)
        {
            result = (Byte)obj1 | (Byte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int16)
        {
            result = (Byte)obj1 | (Int16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt16)
        {
            result = (Byte)obj1 | (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int32)
        {
            result = (Byte)obj1 | (Int32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt32)
        {
            result = (Byte)obj1 | (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int64)
        {
            result = (Byte)obj1 | (Int64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt64)
        {
            result = (Byte)obj1 | (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Char)
        {
            result = (Byte)obj1 | (Char)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Byte)
        {
            result = (Int16)obj1 | (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int16)
        {
            result = (Int16)obj1 | (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt16)
        {
            result = (Int16)obj1 | (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int32)
        {
            result = (Int16)obj1 | (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Char)
        {
            result = (Int16)obj1 | (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Byte)
        {
            result = (UInt16)obj1 | (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int16)
        {
            result = (UInt16)obj1 | (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt16)
        {
            result = (UInt16)obj1 | (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int32)
        {
            result = (UInt16)obj1 | (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt32)
        {
            result = (UInt16)obj1 | (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int64)
        {
            result = (UInt16)obj1 | (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt64)
        {
            result = (UInt16)obj1 | (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Char)
        {
            result = (UInt16)obj1 | (Char)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Byte)
        {
            result = (Int32)obj1 | (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int16)
        {
            result = (Int32)obj1 | (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt16)
        {
            result = (Int32)obj1 | (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int32)
        {
            result = (Int32)obj1 | (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Char)
        {
            result = (Int32)obj1 | (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Byte)
        {
            result = (UInt32)obj1 | (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt16)
        {
            result = (UInt32)obj1 | (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt32)
        {
            result = (UInt32)obj1 | (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int64)
        {
            result = (UInt32)obj1 | (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt64)
        {
            result = (UInt32)obj1 | (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Char)
        {
            result = (UInt32)obj1 | (Char)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Byte)
        {
            result = (Int64)obj1 | (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt16)
        {
            result = (Int64)obj1 | (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt32)
        {
            result = (Int64)obj1 | (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int64)
        {
            result = (Int64)obj1 | (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Char)
        {
            result = (Int64)obj1 | (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Byte)
        {
            result = (UInt64)obj1 | (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt16)
        {
            result = (UInt64)obj1 | (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt32)
        {
            result = (UInt64)obj1 | (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt64)
        {
            result = (UInt64)obj1 | (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Char)
        {
            result = (UInt64)obj1 | (Char)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Byte)
        {
            result = (Char)obj1 | (Byte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int16)
        {
            result = (Char)obj1 | (Int16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt16)
        {
            result = (Char)obj1 | (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int32)
        {
            result = (Char)obj1 | (Int32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt32)
        {
            result = (Char)obj1 | (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int64)
        {
            result = (Char)obj1 | (Int64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt64)
        {
            result = (Char)obj1 | (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Char)
        {
            result = (Char)obj1 | (Char)obj2;
            return true;
        }
    
        result = null;
        return false;
    }
    
    public static bool TryAddition(object obj1, object obj2, out object result)
    {
        Type type1 = obj1.GetType();
        Type type2 = obj2.GetType();
    
        if(obj1 is Boolean && obj2 is String)
        {
            result = (Boolean)obj1 + (String)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Byte)
        {
            result = (Byte)obj1 + (Byte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is SByte)
        {
            result = (Byte)obj1 + (SByte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int16)
        {
            result = (Byte)obj1 + (Int16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt16)
        {
            result = (Byte)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int32)
        {
            result = (Byte)obj1 + (Int32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt32)
        {
            result = (Byte)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int64)
        {
            result = (Byte)obj1 + (Int64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt64)
        {
            result = (Byte)obj1 + (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Char)
        {
            result = (Byte)obj1 + (Char)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Double)
        {
            result = (Byte)obj1 + (Double)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Single)
        {
            result = (Byte)obj1 + (Single)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Decimal)
        {
            result = (Byte)obj1 + (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is String)
        {
            result = (Byte)obj1 + (String)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Byte)
        {
            result = (SByte)obj1 + (Byte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is SByte)
        {
            result = (SByte)obj1 + (SByte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int16)
        {
            result = (SByte)obj1 + (Int16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt16)
        {
            result = (SByte)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int32)
        {
            result = (SByte)obj1 + (Int32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt32)
        {
            result = (SByte)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int64)
        {
            result = (SByte)obj1 + (Int64)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Char)
        {
            result = (SByte)obj1 + (Char)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Double)
        {
            result = (SByte)obj1 + (Double)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Single)
        {
            result = (SByte)obj1 + (Single)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Decimal)
        {
            result = (SByte)obj1 + (Decimal)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is String)
        {
            result = (SByte)obj1 + (String)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Byte)
        {
            result = (Int16)obj1 + (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is SByte)
        {
            result = (Int16)obj1 + (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int16)
        {
            result = (Int16)obj1 + (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt16)
        {
            result = (Int16)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int32)
        {
            result = (Int16)obj1 + (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt32)
        {
            result = (Int16)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int64)
        {
            result = (Int16)obj1 + (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Char)
        {
            result = (Int16)obj1 + (Char)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Double)
        {
            result = (Int16)obj1 + (Double)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Single)
        {
            result = (Int16)obj1 + (Single)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Decimal)
        {
            result = (Int16)obj1 + (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is String)
        {
            result = (Int16)obj1 + (String)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Byte)
        {
            result = (UInt16)obj1 + (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is SByte)
        {
            result = (UInt16)obj1 + (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int16)
        {
            result = (UInt16)obj1 + (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt16)
        {
            result = (UInt16)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int32)
        {
            result = (UInt16)obj1 + (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt32)
        {
            result = (UInt16)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int64)
        {
            result = (UInt16)obj1 + (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt64)
        {
            result = (UInt16)obj1 + (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Char)
        {
            result = (UInt16)obj1 + (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Single)
        {
            result = (UInt16)obj1 + (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Decimal)
        {
            result = (UInt16)obj1 + (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is String)
        {
            result = (UInt16)obj1 + (String)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Byte)
        {
            result = (Int32)obj1 + (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is SByte)
        {
            result = (Int32)obj1 + (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int16)
        {
            result = (Int32)obj1 + (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt16)
        {
            result = (Int32)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int32)
        {
            result = (Int32)obj1 + (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt32)
        {
            result = (Int32)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int64)
        {
            result = (Int32)obj1 + (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Char)
        {
            result = (Int32)obj1 + (Char)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Double)
        {
            result = (Int32)obj1 + (Double)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Single)
        {
            result = (Int32)obj1 + (Single)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Decimal)
        {
            result = (Int32)obj1 + (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is String)
        {
            result = (Int32)obj1 + (String)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Byte)
        {
            result = (UInt32)obj1 + (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is SByte)
        {
            result = (UInt32)obj1 + (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int16)
        {
            result = (UInt32)obj1 + (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt16)
        {
            result = (UInt32)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int32)
        {
            result = (UInt32)obj1 + (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt32)
        {
            result = (UInt32)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int64)
        {
            result = (UInt32)obj1 + (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt64)
        {
            result = (UInt32)obj1 + (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Char)
        {
            result = (UInt32)obj1 + (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Double)
        {
            result = (UInt32)obj1 + (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Single)
        {
            result = (UInt32)obj1 + (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Decimal)
        {
            result = (UInt32)obj1 + (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is String)
        {
            result = (UInt32)obj1 + (String)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Byte)
        {
            result = (Int64)obj1 + (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is SByte)
        {
            result = (Int64)obj1 + (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int16)
        {
            result = (Int64)obj1 + (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt16)
        {
            result = (Int64)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int32)
        {
            result = (Int64)obj1 + (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt32)
        {
            result = (Int64)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int64)
        {
            result = (Int64)obj1 + (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Char)
        {
            result = (Int64)obj1 + (Char)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Double)
        {
            result = (Int64)obj1 + (Double)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Single)
        {
            result = (Int64)obj1 + (Single)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Decimal)
        {
            result = (Int64)obj1 + (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is String)
        {
            result = (Int64)obj1 + (String)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Byte)
        {
            result = (UInt64)obj1 + (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt16)
        {
            result = (UInt64)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt32)
        {
            result = (UInt64)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt64)
        {
            result = (UInt64)obj1 + (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Char)
        {
            result = (UInt64)obj1 + (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Double)
        {
            result = (UInt64)obj1 + (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Single)
        {
            result = (UInt64)obj1 + (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Decimal)
        {
            result = (UInt64)obj1 + (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is String)
        {
            result = (UInt64)obj1 + (String)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Byte)
        {
            result = (Char)obj1 + (Byte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is SByte)
        {
            result = (Char)obj1 + (SByte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int16)
        {
            result = (Char)obj1 + (Int16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt16)
        {
            result = (Char)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int32)
        {
            result = (Char)obj1 + (Int32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt32)
        {
            result = (Char)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int64)
        {
            result = (Char)obj1 + (Int64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt64)
        {
            result = (Char)obj1 + (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Char)
        {
            result = (Char)obj1 + (Char)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Double)
        {
            result = (Char)obj1 + (Double)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Single)
        {
            result = (Char)obj1 + (Single)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Decimal)
        {
            result = (Char)obj1 + (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is String)
        {
            result = (Char)obj1 + (String)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Byte)
        {
            result = (Double)obj1 + (Byte)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is SByte)
        {
            result = (Double)obj1 + (SByte)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int16)
        {
            result = (Double)obj1 + (Int16)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt16)
        {
            result = (Double)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int32)
        {
            result = (Double)obj1 + (Int32)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt32)
        {
            result = (Double)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int64)
        {
            result = (Double)obj1 + (Int64)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt64)
        {
            result = (Double)obj1 + (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Char)
        {
            result = (Double)obj1 + (Char)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Double)
        {
            result = (Double)obj1 + (Double)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Single)
        {
            result = (Double)obj1 + (Single)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is String)
        {
            result = (Double)obj1 + (String)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Byte)
        {
            result = (Single)obj1 + (Byte)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is SByte)
        {
            result = (Single)obj1 + (SByte)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int16)
        {
            result = (Single)obj1 + (Int16)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt16)
        {
            result = (Single)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int32)
        {
            result = (Single)obj1 + (Int32)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt32)
        {
            result = (Single)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int64)
        {
            result = (Single)obj1 + (Int64)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt64)
        {
            result = (Single)obj1 + (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Char)
        {
            result = (Single)obj1 + (Char)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Double)
        {
            result = (Single)obj1 + (Double)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Single)
        {
            result = (Single)obj1 + (Single)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is String)
        {
            result = (Single)obj1 + (String)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Byte)
        {
            result = (Decimal)obj1 + (Byte)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is SByte)
        {
            result = (Decimal)obj1 + (SByte)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int16)
        {
            result = (Decimal)obj1 + (Int16)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt16)
        {
            result = (Decimal)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int32)
        {
            result = (Decimal)obj1 + (Int32)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt32)
        {
            result = (Decimal)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int64)
        {
            result = (Decimal)obj1 + (Int64)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt64)
        {
            result = (Decimal)obj1 + (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Char)
        {
            result = (Decimal)obj1 + (Char)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Decimal)
        {
            result = (Decimal)obj1 + (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is String)
        {
            result = (Decimal)obj1 + (String)obj2;
            return true;
        }
    
        if(obj1 is String && obj2 is Boolean)
        {
            result = (String)obj1 + (Boolean)obj2;
            return true;
        }
    
        if(obj1 is String && obj2 is Byte)
        {
            result = (String)obj1 + (Byte)obj2;
            return true;
        }
    
        if(obj1 is String && obj2 is SByte)
        {
            result = (String)obj1 + (SByte)obj2;
            return true;
        }
    
        if(obj1 is String && obj2 is Int16)
        {
            result = (String)obj1 + (Int16)obj2;
            return true;
        }
    
        if(obj1 is String && obj2 is UInt16)
        {
            result = (String)obj1 + (UInt16)obj2;
            return true;
        }
    
        if(obj1 is String && obj2 is Int32)
        {
            result = (String)obj1 + (Int32)obj2;
            return true;
        }
    
        if(obj1 is String && obj2 is UInt32)
        {
            result = (String)obj1 + (UInt32)obj2;
            return true;
        }
    
        if(obj1 is String && obj2 is Int64)
        {
            result = (String)obj1 + (Int64)obj2;
            return true;
        }
    
        if(obj1 is String && obj2 is UInt64)
        {
            result = (String)obj1 + (UInt64)obj2;
            return true;
        }
    
        if(obj1 is String && obj2 is Char)
        {
            result = (String)obj1 + (Char)obj2;
            return true;
        }
    
        if(obj1 is String && obj2 is Double)
        {
            result = (String)obj1 + (Double)obj2;
            return true;
        }
    
        if(obj1 is String && obj2 is Single)
        {
            result = (String)obj1 + (Single)obj2;
            return true;
        }
    
        if(obj1 is String && obj2 is Decimal)
        {
            result = (String)obj1 + (Decimal)obj2;
            return true;
        }
    
        if(obj1 is String && obj2 is String)
        {
            result = (String)obj1 + (String)obj2;
            return true;
        }
    
        result = null;
        return false;
    }
    
    public static bool TrySubtraction(object obj1, object obj2, out object result)
    {
        Type type1 = obj1.GetType();
        Type type2 = obj2.GetType();
    
        if(obj1 is Byte && obj2 is Byte)
        {
            result = (Byte)obj1 - (Byte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is SByte)
        {
            result = (Byte)obj1 - (SByte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int16)
        {
            result = (Byte)obj1 - (Int16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt16)
        {
            result = (Byte)obj1 - (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int32)
        {
            result = (Byte)obj1 - (Int32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt32)
        {
            result = (Byte)obj1 - (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int64)
        {
            result = (Byte)obj1 - (Int64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt64)
        {
            result = (Byte)obj1 - (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Char)
        {
            result = (Byte)obj1 - (Char)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Double)
        {
            result = (Byte)obj1 - (Double)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Single)
        {
            result = (Byte)obj1 - (Single)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Decimal)
        {
            result = (Byte)obj1 - (Decimal)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Byte)
        {
            result = (SByte)obj1 - (Byte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is SByte)
        {
            result = (SByte)obj1 - (SByte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int16)
        {
            result = (SByte)obj1 - (Int16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt16)
        {
            result = (SByte)obj1 - (UInt16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int32)
        {
            result = (SByte)obj1 - (Int32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt32)
        {
            result = (SByte)obj1 - (UInt32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int64)
        {
            result = (SByte)obj1 - (Int64)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Char)
        {
            result = (SByte)obj1 - (Char)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Single)
        {
            result = (SByte)obj1 - (Single)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Decimal)
        {
            result = (SByte)obj1 - (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Byte)
        {
            result = (Int16)obj1 - (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is SByte)
        {
            result = (Int16)obj1 - (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int16)
        {
            result = (Int16)obj1 - (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt16)
        {
            result = (Int16)obj1 - (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int32)
        {
            result = (Int16)obj1 - (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt32)
        {
            result = (Int16)obj1 - (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int64)
        {
            result = (Int16)obj1 - (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Char)
        {
            result = (Int16)obj1 - (Char)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Double)
        {
            result = (Int16)obj1 - (Double)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Single)
        {
            result = (Int16)obj1 - (Single)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Decimal)
        {
            result = (Int16)obj1 - (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Byte)
        {
            result = (UInt16)obj1 - (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is SByte)
        {
            result = (UInt16)obj1 - (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int16)
        {
            result = (UInt16)obj1 - (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt16)
        {
            result = (UInt16)obj1 - (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int32)
        {
            result = (UInt16)obj1 - (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt32)
        {
            result = (UInt16)obj1 - (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int64)
        {
            result = (UInt16)obj1 - (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt64)
        {
            result = (UInt16)obj1 - (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Char)
        {
            result = (UInt16)obj1 - (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Double)
        {
            result = (UInt16)obj1 - (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Single)
        {
            result = (UInt16)obj1 - (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Decimal)
        {
            result = (UInt16)obj1 - (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Byte)
        {
            result = (Int32)obj1 - (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is SByte)
        {
            result = (Int32)obj1 - (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int16)
        {
            result = (Int32)obj1 - (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt16)
        {
            result = (Int32)obj1 - (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int32)
        {
            result = (Int32)obj1 - (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt32)
        {
            result = (Int32)obj1 - (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int64)
        {
            result = (Int32)obj1 - (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Char)
        {
            result = (Int32)obj1 - (Char)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Double)
        {
            result = (Int32)obj1 - (Double)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Single)
        {
            result = (Int32)obj1 - (Single)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Decimal)
        {
            result = (Int32)obj1 - (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Byte)
        {
            result = (UInt32)obj1 - (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is SByte)
        {
            result = (UInt32)obj1 - (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int16)
        {
            result = (UInt32)obj1 - (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt16)
        {
            result = (UInt32)obj1 - (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int32)
        {
            result = (UInt32)obj1 - (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt32)
        {
            result = (UInt32)obj1 - (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int64)
        {
            result = (UInt32)obj1 - (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt64)
        {
            result = (UInt32)obj1 - (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Char)
        {
            result = (UInt32)obj1 - (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Double)
        {
            result = (UInt32)obj1 - (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Single)
        {
            result = (UInt32)obj1 - (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Decimal)
        {
            result = (UInt32)obj1 - (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Byte)
        {
            result = (Int64)obj1 - (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is SByte)
        {
            result = (Int64)obj1 - (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int16)
        {
            result = (Int64)obj1 - (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt16)
        {
            result = (Int64)obj1 - (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int32)
        {
            result = (Int64)obj1 - (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt32)
        {
            result = (Int64)obj1 - (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int64)
        {
            result = (Int64)obj1 - (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Char)
        {
            result = (Int64)obj1 - (Char)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Double)
        {
            result = (Int64)obj1 - (Double)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Single)
        {
            result = (Int64)obj1 - (Single)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Decimal)
        {
            result = (Int64)obj1 - (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Byte)
        {
            result = (UInt64)obj1 - (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt16)
        {
            result = (UInt64)obj1 - (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt32)
        {
            result = (UInt64)obj1 - (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt64)
        {
            result = (UInt64)obj1 - (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Char)
        {
            result = (UInt64)obj1 - (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Double)
        {
            result = (UInt64)obj1 - (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Single)
        {
            result = (UInt64)obj1 - (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Decimal)
        {
            result = (UInt64)obj1 - (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Byte)
        {
            result = (Char)obj1 - (Byte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is SByte)
        {
            result = (Char)obj1 - (SByte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int16)
        {
            result = (Char)obj1 - (Int16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt16)
        {
            result = (Char)obj1 - (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int32)
        {
            result = (Char)obj1 - (Int32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt32)
        {
            result = (Char)obj1 - (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int64)
        {
            result = (Char)obj1 - (Int64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt64)
        {
            result = (Char)obj1 - (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Char)
        {
            result = (Char)obj1 - (Char)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Double)
        {
            result = (Char)obj1 - (Double)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Single)
        {
            result = (Char)obj1 - (Single)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Decimal)
        {
            result = (Char)obj1 - (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Byte)
        {
            result = (Double)obj1 - (Byte)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is SByte)
        {
            result = (Double)obj1 - (SByte)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int16)
        {
            result = (Double)obj1 - (Int16)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt16)
        {
            result = (Double)obj1 - (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int32)
        {
            result = (Double)obj1 - (Int32)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt32)
        {
            result = (Double)obj1 - (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int64)
        {
            result = (Double)obj1 - (Int64)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt64)
        {
            result = (Double)obj1 - (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Char)
        {
            result = (Double)obj1 - (Char)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Double)
        {
            result = (Double)obj1 - (Double)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Single)
        {
            result = (Double)obj1 - (Single)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Byte)
        {
            result = (Single)obj1 - (Byte)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is SByte)
        {
            result = (Single)obj1 - (SByte)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int16)
        {
            result = (Single)obj1 - (Int16)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt16)
        {
            result = (Single)obj1 - (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int32)
        {
            result = (Single)obj1 - (Int32)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt32)
        {
            result = (Single)obj1 - (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int64)
        {
            result = (Single)obj1 - (Int64)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt64)
        {
            result = (Single)obj1 - (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Char)
        {
            result = (Single)obj1 - (Char)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Double)
        {
            result = (Single)obj1 - (Double)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Single)
        {
            result = (Single)obj1 - (Single)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Byte)
        {
            result = (Decimal)obj1 - (Byte)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is SByte)
        {
            result = (Decimal)obj1 - (SByte)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int16)
        {
            result = (Decimal)obj1 - (Int16)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt16)
        {
            result = (Decimal)obj1 - (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int32)
        {
            result = (Decimal)obj1 - (Int32)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt32)
        {
            result = (Decimal)obj1 - (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int64)
        {
            result = (Decimal)obj1 - (Int64)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt64)
        {
            result = (Decimal)obj1 - (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Char)
        {
            result = (Decimal)obj1 - (Char)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Decimal)
        {
            result = (Decimal)obj1 - (Decimal)obj2;
            return true;
        }
    
        result = null;
        return false;
    }
    
    public static bool TryDivision(object obj1, object obj2, out object result)
    {
        Type type1 = obj1.GetType();
        Type type2 = obj2.GetType();
    
        if(obj1 is Byte && obj2 is Byte)
        {
            result = (Byte)obj1 / (Byte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is SByte)
        {
            result = (Byte)obj1 / (SByte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int16)
        {
            result = (Byte)obj1 / (Int16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt16)
        {
            result = (Byte)obj1 / (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int32)
        {
            result = (Byte)obj1 / (Int32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int64)
        {
            result = (Byte)obj1 / (Int64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt64)
        {
            result = (Byte)obj1 / (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Char)
        {
            result = (Byte)obj1 / (Char)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Double)
        {
            result = (Byte)obj1 / (Double)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Single)
        {
            result = (Byte)obj1 / (Single)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Decimal)
        {
            result = (Byte)obj1 / (Decimal)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Byte)
        {
            result = (SByte)obj1 / (Byte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is SByte)
        {
            result = (SByte)obj1 / (SByte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int16)
        {
            result = (SByte)obj1 / (Int16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt16)
        {
            result = (SByte)obj1 / (UInt16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int32)
        {
            result = (SByte)obj1 / (Int32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt32)
        {
            result = (SByte)obj1 / (UInt32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int64)
        {
            result = (SByte)obj1 / (Int64)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Char)
        {
            result = (SByte)obj1 / (Char)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Double)
        {
            result = (SByte)obj1 / (Double)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Single)
        {
            result = (SByte)obj1 / (Single)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Decimal)
        {
            result = (SByte)obj1 / (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Byte)
        {
            result = (Int16)obj1 / (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is SByte)
        {
            result = (Int16)obj1 / (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int16)
        {
            result = (Int16)obj1 / (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt16)
        {
            result = (Int16)obj1 / (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int32)
        {
            result = (Int16)obj1 / (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt32)
        {
            result = (Int16)obj1 / (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int64)
        {
            result = (Int16)obj1 / (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Char)
        {
            result = (Int16)obj1 / (Char)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Double)
        {
            result = (Int16)obj1 / (Double)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Single)
        {
            result = (Int16)obj1 / (Single)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Decimal)
        {
            result = (Int16)obj1 / (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Byte)
        {
            result = (UInt16)obj1 / (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is SByte)
        {
            result = (UInt16)obj1 / (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int16)
        {
            result = (UInt16)obj1 / (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt16)
        {
            result = (UInt16)obj1 / (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int32)
        {
            result = (UInt16)obj1 / (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt32)
        {
            result = (UInt16)obj1 / (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int64)
        {
            result = (UInt16)obj1 / (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt64)
        {
            result = (UInt16)obj1 / (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Char)
        {
            result = (UInt16)obj1 / (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Double)
        {
            result = (UInt16)obj1 / (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Single)
        {
            result = (UInt16)obj1 / (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Decimal)
        {
            result = (UInt16)obj1 / (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Byte)
        {
            result = (Int32)obj1 / (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is SByte)
        {
            result = (Int32)obj1 / (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int16)
        {
            result = (Int32)obj1 / (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt16)
        {
            result = (Int32)obj1 / (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int32)
        {
            result = (Int32)obj1 / (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt32)
        {
            result = (Int32)obj1 / (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int64)
        {
            result = (Int32)obj1 / (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Char)
        {
            result = (Int32)obj1 / (Char)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Double)
        {
            result = (Int32)obj1 / (Double)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Single)
        {
            result = (Int32)obj1 / (Single)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Decimal)
        {
            result = (Int32)obj1 / (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Byte)
        {
            result = (UInt32)obj1 / (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is SByte)
        {
            result = (UInt32)obj1 / (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int16)
        {
            result = (UInt32)obj1 / (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt16)
        {
            result = (UInt32)obj1 / (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int32)
        {
            result = (UInt32)obj1 / (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt32)
        {
            result = (UInt32)obj1 / (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int64)
        {
            result = (UInt32)obj1 / (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt64)
        {
            result = (UInt32)obj1 / (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Char)
        {
            result = (UInt32)obj1 / (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Double)
        {
            result = (UInt32)obj1 / (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Single)
        {
            result = (UInt32)obj1 / (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Decimal)
        {
            result = (UInt32)obj1 / (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Byte)
        {
            result = (Int64)obj1 / (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is SByte)
        {
            result = (Int64)obj1 / (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int16)
        {
            result = (Int64)obj1 / (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt16)
        {
            result = (Int64)obj1 / (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int32)
        {
            result = (Int64)obj1 / (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt32)
        {
            result = (Int64)obj1 / (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int64)
        {
            result = (Int64)obj1 / (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Char)
        {
            result = (Int64)obj1 / (Char)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Double)
        {
            result = (Int64)obj1 / (Double)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Single)
        {
            result = (Int64)obj1 / (Single)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Decimal)
        {
            result = (Int64)obj1 / (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Byte)
        {
            result = (UInt64)obj1 / (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt16)
        {
            result = (UInt64)obj1 / (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt32)
        {
            result = (UInt64)obj1 / (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt64)
        {
            result = (UInt64)obj1 / (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Char)
        {
            result = (UInt64)obj1 / (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Double)
        {
            result = (UInt64)obj1 / (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Single)
        {
            result = (UInt64)obj1 / (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Decimal)
        {
            result = (UInt64)obj1 / (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Byte)
        {
            result = (Char)obj1 / (Byte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is SByte)
        {
            result = (Char)obj1 / (SByte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int16)
        {
            result = (Char)obj1 / (Int16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt16)
        {
            result = (Char)obj1 / (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int32)
        {
            result = (Char)obj1 / (Int32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt32)
        {
            result = (Char)obj1 / (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int64)
        {
            result = (Char)obj1 / (Int64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt64)
        {
            result = (Char)obj1 / (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Char)
        {
            result = (Char)obj1 / (Char)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Double)
        {
            result = (Char)obj1 / (Double)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Single)
        {
            result = (Char)obj1 / (Single)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Decimal)
        {
            result = (Char)obj1 / (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Byte)
        {
            result = (Double)obj1 / (Byte)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is SByte)
        {
            result = (Double)obj1 / (SByte)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int16)
        {
            result = (Double)obj1 / (Int16)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt16)
        {
            result = (Double)obj1 / (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int32)
        {
            result = (Double)obj1 / (Int32)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt32)
        {
            result = (Double)obj1 / (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int64)
        {
            result = (Double)obj1 / (Int64)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt64)
        {
            result = (Double)obj1 / (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Char)
        {
            result = (Double)obj1 / (Char)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Double)
        {
            result = (Double)obj1 / (Double)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Single)
        {
            result = (Double)obj1 / (Single)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Byte)
        {
            result = (Single)obj1 / (Byte)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is SByte)
        {
            result = (Single)obj1 / (SByte)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int16)
        {
            result = (Single)obj1 / (Int16)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt16)
        {
            result = (Single)obj1 / (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int32)
        {
            result = (Single)obj1 / (Int32)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt32)
        {
            result = (Single)obj1 / (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int64)
        {
            result = (Single)obj1 / (Int64)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt64)
        {
            result = (Single)obj1 / (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Char)
        {
            result = (Single)obj1 / (Char)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Double)
        {
            result = (Single)obj1 / (Double)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Single)
        {
            result = (Single)obj1 / (Single)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Byte)
        {
            result = (Decimal)obj1 / (Byte)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is SByte)
        {
            result = (Decimal)obj1 / (SByte)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int16)
        {
            result = (Decimal)obj1 / (Int16)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt16)
        {
            result = (Decimal)obj1 / (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int32)
        {
            result = (Decimal)obj1 / (Int32)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt32)
        {
            result = (Decimal)obj1 / (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int64)
        {
            result = (Decimal)obj1 / (Int64)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt64)
        {
            result = (Decimal)obj1 / (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Char)
        {
            result = (Decimal)obj1 / (Char)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Decimal)
        {
            result = (Decimal)obj1 / (Decimal)obj2;
            return true;
        }
    
        result = null;
        return false;
    }
    
    public static bool TryModulus(object obj1, object obj2, out object result)
    {
        Type type1 = obj1.GetType();
        Type type2 = obj2.GetType();
    
        if(obj1 is Byte && obj2 is Byte)
        {
            result = (Byte)obj1 % (Byte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is SByte)
        {
            result = (Byte)obj1 % (SByte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int16)
        {
            result = (Byte)obj1 % (Int16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt16)
        {
            result = (Byte)obj1 % (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int32)
        {
            result = (Byte)obj1 % (Int32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt32)
        {
            result = (Byte)obj1 % (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int64)
        {
            result = (Byte)obj1 % (Int64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt64)
        {
            result = (Byte)obj1 % (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Char)
        {
            result = (Byte)obj1 % (Char)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Double)
        {
            result = (Byte)obj1 % (Double)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Single)
        {
            result = (Byte)obj1 % (Single)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Decimal)
        {
            result = (Byte)obj1 % (Decimal)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Byte)
        {
            result = (SByte)obj1 % (Byte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is SByte)
        {
            result = (SByte)obj1 % (SByte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int16)
        {
            result = (SByte)obj1 % (Int16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt16)
        {
            result = (SByte)obj1 % (UInt16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int32)
        {
            result = (SByte)obj1 % (Int32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt32)
        {
            result = (SByte)obj1 % (UInt32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int64)
        {
            result = (SByte)obj1 % (Int64)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Char)
        {
            result = (SByte)obj1 % (Char)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Double)
        {
            result = (SByte)obj1 % (Double)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Single)
        {
            result = (SByte)obj1 % (Single)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Decimal)
        {
            result = (SByte)obj1 % (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Byte)
        {
            result = (Int16)obj1 % (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is SByte)
        {
            result = (Int16)obj1 % (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int16)
        {
            result = (Int16)obj1 % (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt16)
        {
            result = (Int16)obj1 % (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int32)
        {
            result = (Int16)obj1 % (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt32)
        {
            result = (Int16)obj1 % (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int64)
        {
            result = (Int16)obj1 % (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Char)
        {
            result = (Int16)obj1 % (Char)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Double)
        {
            result = (Int16)obj1 % (Double)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Single)
        {
            result = (Int16)obj1 % (Single)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Decimal)
        {
            result = (Int16)obj1 % (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Byte)
        {
            result = (UInt16)obj1 % (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is SByte)
        {
            result = (UInt16)obj1 % (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int16)
        {
            result = (UInt16)obj1 % (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt16)
        {
            result = (UInt16)obj1 % (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int32)
        {
            result = (UInt16)obj1 % (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt32)
        {
            result = (UInt16)obj1 % (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int64)
        {
            result = (UInt16)obj1 % (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt64)
        {
            result = (UInt16)obj1 % (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Char)
        {
            result = (UInt16)obj1 % (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Double)
        {
            result = (UInt16)obj1 % (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Single)
        {
            result = (UInt16)obj1 % (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Decimal)
        {
            result = (UInt16)obj1 % (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Byte)
        {
            result = (Int32)obj1 % (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is SByte)
        {
            result = (Int32)obj1 % (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int16)
        {
            result = (Int32)obj1 % (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt16)
        {
            result = (Int32)obj1 % (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int32)
        {
            result = (Int32)obj1 % (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt32)
        {
            result = (Int32)obj1 % (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int64)
        {
            result = (Int32)obj1 % (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Char)
        {
            result = (Int32)obj1 % (Char)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Double)
        {
            result = (Int32)obj1 % (Double)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Single)
        {
            result = (Int32)obj1 % (Single)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Decimal)
        {
            result = (Int32)obj1 % (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Byte)
        {
            result = (UInt32)obj1 % (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is SByte)
        {
            result = (UInt32)obj1 % (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int16)
        {
            result = (UInt32)obj1 % (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt16)
        {
            result = (UInt32)obj1 % (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int32)
        {
            result = (UInt32)obj1 % (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt32)
        {
            result = (UInt32)obj1 % (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int64)
        {
            result = (UInt32)obj1 % (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt64)
        {
            result = (UInt32)obj1 % (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Char)
        {
            result = (UInt32)obj1 % (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Double)
        {
            result = (UInt32)obj1 % (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Single)
        {
            result = (UInt32)obj1 % (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Decimal)
        {
            result = (UInt32)obj1 % (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Byte)
        {
            result = (Int64)obj1 % (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is SByte)
        {
            result = (Int64)obj1 % (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int16)
        {
            result = (Int64)obj1 % (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt16)
        {
            result = (Int64)obj1 % (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int32)
        {
            result = (Int64)obj1 % (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt32)
        {
            result = (Int64)obj1 % (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int64)
        {
            result = (Int64)obj1 % (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Char)
        {
            result = (Int64)obj1 % (Char)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Double)
        {
            result = (Int64)obj1 % (Double)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Single)
        {
            result = (Int64)obj1 % (Single)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Decimal)
        {
            result = (Int64)obj1 % (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Byte)
        {
            result = (UInt64)obj1 % (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt16)
        {
            result = (UInt64)obj1 % (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt32)
        {
            result = (UInt64)obj1 % (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt64)
        {
            result = (UInt64)obj1 % (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Char)
        {
            result = (UInt64)obj1 % (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Double)
        {
            result = (UInt64)obj1 % (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Single)
        {
            result = (UInt64)obj1 % (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Decimal)
        {
            result = (UInt64)obj1 % (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Byte)
        {
            result = (Char)obj1 % (Byte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is SByte)
        {
            result = (Char)obj1 % (SByte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int16)
        {
            result = (Char)obj1 % (Int16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt16)
        {
            result = (Char)obj1 % (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int32)
        {
            result = (Char)obj1 % (Int32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt32)
        {
            result = (Char)obj1 % (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int64)
        {
            result = (Char)obj1 % (Int64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt64)
        {
            result = (Char)obj1 % (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Char)
        {
            result = (Char)obj1 % (Char)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Double)
        {
            result = (Char)obj1 % (Double)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Single)
        {
            result = (Char)obj1 % (Single)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Decimal)
        {
            result = (Char)obj1 % (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Byte)
        {
            result = (Double)obj1 % (Byte)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is SByte)
        {
            result = (Double)obj1 % (SByte)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int16)
        {
            result = (Double)obj1 % (Int16)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt16)
        {
            result = (Double)obj1 % (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int32)
        {
            result = (Double)obj1 % (Int32)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt32)
        {
            result = (Double)obj1 % (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int64)
        {
            result = (Double)obj1 % (Int64)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt64)
        {
            result = (Double)obj1 % (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Char)
        {
            result = (Double)obj1 % (Char)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Double)
        {
            result = (Double)obj1 % (Double)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Single)
        {
            result = (Double)obj1 % (Single)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Byte)
        {
            result = (Single)obj1 % (Byte)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is SByte)
        {
            result = (Single)obj1 % (SByte)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int16)
        {
            result = (Single)obj1 % (Int16)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt16)
        {
            result = (Single)obj1 % (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int32)
        {
            result = (Single)obj1 % (Int32)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt32)
        {
            result = (Single)obj1 % (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int64)
        {
            result = (Single)obj1 % (Int64)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt64)
        {
            result = (Single)obj1 % (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Double)
        {
            result = (Single)obj1 % (Double)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Single)
        {
            result = (Single)obj1 % (Single)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Byte)
        {
            result = (Decimal)obj1 % (Byte)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is SByte)
        {
            result = (Decimal)obj1 % (SByte)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int16)
        {
            result = (Decimal)obj1 % (Int16)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt16)
        {
            result = (Decimal)obj1 % (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int32)
        {
            result = (Decimal)obj1 % (Int32)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt32)
        {
            result = (Decimal)obj1 % (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int64)
        {
            result = (Decimal)obj1 % (Int64)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt64)
        {
            result = (Decimal)obj1 % (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Char)
        {
            result = (Decimal)obj1 % (Char)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Decimal)
        {
            result = (Decimal)obj1 % (Decimal)obj2;
            return true;
        }
    
        result = null;
        return false;
    }
    
    public static bool TryMultiply(object obj1, object obj2, out object result)
    {
        Type type1 = obj1.GetType();
        Type type2 = obj2.GetType();
    
        if(obj1 is Byte && obj2 is Byte)
        {
            result = (Byte)obj1 * (Byte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is SByte)
        {
            result = (Byte)obj1 * (SByte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int16)
        {
            result = (Byte)obj1 * (Int16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt16)
        {
            result = (Byte)obj1 * (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int32)
        {
            result = (Byte)obj1 * (Int32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt32)
        {
            result = (Byte)obj1 * (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int64)
        {
            result = (Byte)obj1 * (Int64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt64)
        {
            result = (Byte)obj1 * (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Char)
        {
            result = (Byte)obj1 * (Char)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Double)
        {
            result = (Byte)obj1 * (Double)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Single)
        {
            result = (Byte)obj1 * (Single)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Decimal)
        {
            result = (Byte)obj1 * (Decimal)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Byte)
        {
            result = (SByte)obj1 * (Byte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is SByte)
        {
            result = (SByte)obj1 * (SByte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int16)
        {
            result = (SByte)obj1 * (Int16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt16)
        {
            result = (SByte)obj1 * (UInt16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int32)
        {
            result = (SByte)obj1 * (Int32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt32)
        {
            result = (SByte)obj1 * (UInt32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int64)
        {
            result = (SByte)obj1 * (Int64)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Char)
        {
            result = (SByte)obj1 * (Char)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Double)
        {
            result = (SByte)obj1 * (Double)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Single)
        {
            result = (SByte)obj1 * (Single)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Decimal)
        {
            result = (SByte)obj1 * (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Byte)
        {
            result = (Int16)obj1 * (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is SByte)
        {
            result = (Int16)obj1 * (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int16)
        {
            result = (Int16)obj1 * (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt16)
        {
            result = (Int16)obj1 * (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int32)
        {
            result = (Int16)obj1 * (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt32)
        {
            result = (Int16)obj1 * (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int64)
        {
            result = (Int16)obj1 * (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Char)
        {
            result = (Int16)obj1 * (Char)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Double)
        {
            result = (Int16)obj1 * (Double)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Single)
        {
            result = (Int16)obj1 * (Single)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Decimal)
        {
            result = (Int16)obj1 * (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Byte)
        {
            result = (UInt16)obj1 * (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is SByte)
        {
            result = (UInt16)obj1 * (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int16)
        {
            result = (UInt16)obj1 * (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt16)
        {
            result = (UInt16)obj1 * (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int32)
        {
            result = (UInt16)obj1 * (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt32)
        {
            result = (UInt16)obj1 * (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int64)
        {
            result = (UInt16)obj1 * (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt64)
        {
            result = (UInt16)obj1 * (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Char)
        {
            result = (UInt16)obj1 * (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Double)
        {
            result = (UInt16)obj1 * (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Single)
        {
            result = (UInt16)obj1 * (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Decimal)
        {
            result = (UInt16)obj1 * (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Byte)
        {
            result = (Int32)obj1 * (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is SByte)
        {
            result = (Int32)obj1 * (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int16)
        {
            result = (Int32)obj1 * (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt16)
        {
            result = (Int32)obj1 * (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int32)
        {
            result = (Int32)obj1 * (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt32)
        {
            result = (Int32)obj1 * (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int64)
        {
            result = (Int32)obj1 * (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Char)
        {
            result = (Int32)obj1 * (Char)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Double)
        {
            result = (Int32)obj1 * (Double)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Single)
        {
            result = (Int32)obj1 * (Single)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Decimal)
        {
            result = (Int32)obj1 * (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Byte)
        {
            result = (UInt32)obj1 * (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is SByte)
        {
            result = (UInt32)obj1 * (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int16)
        {
            result = (UInt32)obj1 * (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt16)
        {
            result = (UInt32)obj1 * (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int32)
        {
            result = (UInt32)obj1 * (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt32)
        {
            result = (UInt32)obj1 * (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int64)
        {
            result = (UInt32)obj1 * (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt64)
        {
            result = (UInt32)obj1 * (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Char)
        {
            result = (UInt32)obj1 * (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Double)
        {
            result = (UInt32)obj1 * (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Single)
        {
            result = (UInt32)obj1 * (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Decimal)
        {
            result = (UInt32)obj1 * (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Byte)
        {
            result = (Int64)obj1 * (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is SByte)
        {
            result = (Int64)obj1 * (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int16)
        {
            result = (Int64)obj1 * (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt16)
        {
            result = (Int64)obj1 * (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int32)
        {
            result = (Int64)obj1 * (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt32)
        {
            result = (Int64)obj1 * (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int64)
        {
            result = (Int64)obj1 * (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Char)
        {
            result = (Int64)obj1 * (Char)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Double)
        {
            result = (Int64)obj1 * (Double)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Single)
        {
            result = (Int64)obj1 * (Single)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Decimal)
        {
            result = (Int64)obj1 * (Decimal)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Byte)
        {
            result = (UInt64)obj1 * (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt16)
        {
            result = (UInt64)obj1 * (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt32)
        {
            result = (UInt64)obj1 * (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt64)
        {
            result = (UInt64)obj1 * (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Char)
        {
            result = (UInt64)obj1 * (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Double)
        {
            result = (UInt64)obj1 * (Double)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Single)
        {
            result = (UInt64)obj1 * (Single)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Decimal)
        {
            result = (UInt64)obj1 * (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Byte)
        {
            result = (Char)obj1 * (Byte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is SByte)
        {
            result = (Char)obj1 * (SByte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int16)
        {
            result = (Char)obj1 * (Int16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt16)
        {
            result = (Char)obj1 * (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int32)
        {
            result = (Char)obj1 * (Int32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt32)
        {
            result = (Char)obj1 * (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int64)
        {
            result = (Char)obj1 * (Int64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Char)
        {
            result = (Char)obj1 * (Char)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Double)
        {
            result = (Char)obj1 * (Double)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Single)
        {
            result = (Char)obj1 * (Single)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Decimal)
        {
            result = (Char)obj1 * (Decimal)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Byte)
        {
            result = (Double)obj1 * (Byte)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int16)
        {
            result = (Double)obj1 * (Int16)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt16)
        {
            result = (Double)obj1 * (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int32)
        {
            result = (Double)obj1 * (Int32)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt32)
        {
            result = (Double)obj1 * (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Int64)
        {
            result = (Double)obj1 * (Int64)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is UInt64)
        {
            result = (Double)obj1 * (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Char)
        {
            result = (Double)obj1 * (Char)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Double)
        {
            result = (Double)obj1 * (Double)obj2;
            return true;
        }
    
        if(obj1 is Double && obj2 is Single)
        {
            result = (Double)obj1 * (Single)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Byte)
        {
            result = (Single)obj1 * (Byte)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is SByte)
        {
            result = (Single)obj1 * (SByte)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int16)
        {
            result = (Single)obj1 * (Int16)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt16)
        {
            result = (Single)obj1 * (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int32)
        {
            result = (Single)obj1 * (Int32)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt32)
        {
            result = (Single)obj1 * (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Int64)
        {
            result = (Single)obj1 * (Int64)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is UInt64)
        {
            result = (Single)obj1 * (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Char)
        {
            result = (Single)obj1 * (Char)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Double)
        {
            result = (Single)obj1 * (Double)obj2;
            return true;
        }
    
        if(obj1 is Single && obj2 is Single)
        {
            result = (Single)obj1 * (Single)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Byte)
        {
            result = (Decimal)obj1 * (Byte)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is SByte)
        {
            result = (Decimal)obj1 * (SByte)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int16)
        {
            result = (Decimal)obj1 * (Int16)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt16)
        {
            result = (Decimal)obj1 * (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int32)
        {
            result = (Decimal)obj1 * (Int32)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt32)
        {
            result = (Decimal)obj1 * (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Int64)
        {
            result = (Decimal)obj1 * (Int64)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is UInt64)
        {
            result = (Decimal)obj1 * (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Char)
        {
            result = (Decimal)obj1 * (Char)obj2;
            return true;
        }
    
        if(obj1 is Decimal && obj2 is Decimal)
        {
            result = (Decimal)obj1 * (Decimal)obj2;
            return true;
        }
    
        result = null;
        return false;
    }
    
    public static bool TryLeftShift(object obj1, object obj2, out object result)
    {
        Type type1 = obj1.GetType();
        Type type2 = obj2.GetType();
    
        if(obj1 is Byte && obj2 is Byte)
        {
            result = (Byte)obj1 << (Byte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is SByte)
        {
            result = (Byte)obj1 << (SByte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int16)
        {
            result = (Byte)obj1 << (Int16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt16)
        {
            result = (Byte)obj1 << (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int32)
        {
            result = (Byte)obj1 << (Int32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Char)
        {
            result = (Byte)obj1 << (Char)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Byte)
        {
            result = (SByte)obj1 << (Byte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is SByte)
        {
            result = (SByte)obj1 << (SByte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int16)
        {
            result = (SByte)obj1 << (Int16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt16)
        {
            result = (SByte)obj1 << (UInt16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int32)
        {
            result = (SByte)obj1 << (Int32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Char)
        {
            result = (SByte)obj1 << (Char)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Byte)
        {
            result = (Int16)obj1 << (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is SByte)
        {
            result = (Int16)obj1 << (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int16)
        {
            result = (Int16)obj1 << (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt16)
        {
            result = (Int16)obj1 << (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int32)
        {
            result = (Int16)obj1 << (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Char)
        {
            result = (Int16)obj1 << (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Byte)
        {
            result = (UInt16)obj1 << (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is SByte)
        {
            result = (UInt16)obj1 << (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int16)
        {
            result = (UInt16)obj1 << (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt16)
        {
            result = (UInt16)obj1 << (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int32)
        {
            result = (UInt16)obj1 << (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Char)
        {
            result = (UInt16)obj1 << (Char)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Byte)
        {
            result = (Int32)obj1 << (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is SByte)
        {
            result = (Int32)obj1 << (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int16)
        {
            result = (Int32)obj1 << (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt16)
        {
            result = (Int32)obj1 << (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int32)
        {
            result = (Int32)obj1 << (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Char)
        {
            result = (Int32)obj1 << (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Byte)
        {
            result = (UInt32)obj1 << (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is SByte)
        {
            result = (UInt32)obj1 << (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int16)
        {
            result = (UInt32)obj1 << (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt16)
        {
            result = (UInt32)obj1 << (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int32)
        {
            result = (UInt32)obj1 << (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Char)
        {
            result = (UInt32)obj1 << (Char)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Byte)
        {
            result = (Int64)obj1 << (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is SByte)
        {
            result = (Int64)obj1 << (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int16)
        {
            result = (Int64)obj1 << (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt16)
        {
            result = (Int64)obj1 << (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int32)
        {
            result = (Int64)obj1 << (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Char)
        {
            result = (Int64)obj1 << (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Byte)
        {
            result = (UInt64)obj1 << (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is SByte)
        {
            result = (UInt64)obj1 << (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Int16)
        {
            result = (UInt64)obj1 << (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt16)
        {
            result = (UInt64)obj1 << (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Int32)
        {
            result = (UInt64)obj1 << (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Char)
        {
            result = (UInt64)obj1 << (Char)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Byte)
        {
            result = (Char)obj1 << (Byte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is SByte)
        {
            result = (Char)obj1 << (SByte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int16)
        {
            result = (Char)obj1 << (Int16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt16)
        {
            result = (Char)obj1 << (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int32)
        {
            result = (Char)obj1 << (Int32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Char)
        {
            result = (Char)obj1 << (Char)obj2;
            return true;
        }
    
        result = null;
        return false;
    }
    
    public static bool TryRightShift(object obj1, object obj2, out object result)
    {
        Type type1 = obj1.GetType();
        Type type2 = obj2.GetType();
    
        if(obj1 is Byte && obj2 is Byte)
        {
            result = (Byte)obj1 >> (Byte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is SByte)
        {
            result = (Byte)obj1 >> (SByte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int16)
        {
            result = (Byte)obj1 >> (Int16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt16)
        {
            result = (Byte)obj1 >> (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int32)
        {
            result = (Byte)obj1 >> (Int32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Char)
        {
            result = (Byte)obj1 >> (Char)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Byte)
        {
            result = (SByte)obj1 >> (Byte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is SByte)
        {
            result = (SByte)obj1 >> (SByte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int16)
        {
            result = (SByte)obj1 >> (Int16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt16)
        {
            result = (SByte)obj1 >> (UInt16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int32)
        {
            result = (SByte)obj1 >> (Int32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Char)
        {
            result = (SByte)obj1 >> (Char)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Byte)
        {
            result = (Int16)obj1 >> (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is SByte)
        {
            result = (Int16)obj1 >> (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int16)
        {
            result = (Int16)obj1 >> (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt16)
        {
            result = (Int16)obj1 >> (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int32)
        {
            result = (Int16)obj1 >> (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Char)
        {
            result = (Int16)obj1 >> (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Byte)
        {
            result = (UInt16)obj1 >> (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is SByte)
        {
            result = (UInt16)obj1 >> (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int16)
        {
            result = (UInt16)obj1 >> (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt16)
        {
            result = (UInt16)obj1 >> (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int32)
        {
            result = (UInt16)obj1 >> (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Char)
        {
            result = (UInt16)obj1 >> (Char)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Byte)
        {
            result = (Int32)obj1 >> (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is SByte)
        {
            result = (Int32)obj1 >> (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int16)
        {
            result = (Int32)obj1 >> (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt16)
        {
            result = (Int32)obj1 >> (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int32)
        {
            result = (Int32)obj1 >> (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Char)
        {
            result = (Int32)obj1 >> (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Byte)
        {
            result = (UInt32)obj1 >> (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is SByte)
        {
            result = (UInt32)obj1 >> (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int16)
        {
            result = (UInt32)obj1 >> (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt16)
        {
            result = (UInt32)obj1 >> (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int32)
        {
            result = (UInt32)obj1 >> (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Char)
        {
            result = (UInt32)obj1 >> (Char)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Byte)
        {
            result = (Int64)obj1 >> (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is SByte)
        {
            result = (Int64)obj1 >> (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int16)
        {
            result = (Int64)obj1 >> (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt16)
        {
            result = (Int64)obj1 >> (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int32)
        {
            result = (Int64)obj1 >> (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Char)
        {
            result = (Int64)obj1 >> (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Byte)
        {
            result = (UInt64)obj1 >> (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is SByte)
        {
            result = (UInt64)obj1 >> (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Int16)
        {
            result = (UInt64)obj1 >> (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt16)
        {
            result = (UInt64)obj1 >> (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Int32)
        {
            result = (UInt64)obj1 >> (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Char)
        {
            result = (UInt64)obj1 >> (Char)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Byte)
        {
            result = (Char)obj1 >> (Byte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is SByte)
        {
            result = (Char)obj1 >> (SByte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int16)
        {
            result = (Char)obj1 >> (Int16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt16)
        {
            result = (Char)obj1 >> (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int32)
        {
            result = (Char)obj1 >> (Int32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Char)
        {
            result = (Char)obj1 >> (Char)obj2;
            return true;
        }
    
        result = null;
        return false;
    }
    
    public static bool TryExclusiveOr(object obj1, object obj2, out object result)
    {
        Type type1 = obj1.GetType();
        Type type2 = obj2.GetType();
    
        if(obj1 is Boolean && obj2 is Boolean)
        {
            result = (Boolean)obj1 ^ (Boolean)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Byte)
        {
            result = (Byte)obj1 ^ (Byte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is SByte)
        {
            result = (Byte)obj1 ^ (SByte)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int16)
        {
            result = (Byte)obj1 ^ (Int16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt16)
        {
            result = (Byte)obj1 ^ (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int32)
        {
            result = (Byte)obj1 ^ (Int32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt32)
        {
            result = (Byte)obj1 ^ (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Int64)
        {
            result = (Byte)obj1 ^ (Int64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is UInt64)
        {
            result = (Byte)obj1 ^ (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Byte && obj2 is Char)
        {
            result = (Byte)obj1 ^ (Char)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Byte)
        {
            result = (SByte)obj1 ^ (Byte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is SByte)
        {
            result = (SByte)obj1 ^ (SByte)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int16)
        {
            result = (SByte)obj1 ^ (Int16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt16)
        {
            result = (SByte)obj1 ^ (UInt16)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int32)
        {
            result = (SByte)obj1 ^ (Int32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is UInt32)
        {
            result = (SByte)obj1 ^ (UInt32)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Int64)
        {
            result = (SByte)obj1 ^ (Int64)obj2;
            return true;
        }
    
        if(obj1 is SByte && obj2 is Char)
        {
            result = (SByte)obj1 ^ (Char)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Byte)
        {
            result = (Int16)obj1 ^ (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is SByte)
        {
            result = (Int16)obj1 ^ (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int16)
        {
            result = (Int16)obj1 ^ (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt16)
        {
            result = (Int16)obj1 ^ (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int32)
        {
            result = (Int16)obj1 ^ (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is UInt32)
        {
            result = (Int16)obj1 ^ (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Int64)
        {
            result = (Int16)obj1 ^ (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int16 && obj2 is Char)
        {
            result = (Int16)obj1 ^ (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Byte)
        {
            result = (UInt16)obj1 ^ (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is SByte)
        {
            result = (UInt16)obj1 ^ (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int16)
        {
            result = (UInt16)obj1 ^ (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt16)
        {
            result = (UInt16)obj1 ^ (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int32)
        {
            result = (UInt16)obj1 ^ (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt32)
        {
            result = (UInt16)obj1 ^ (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Int64)
        {
            result = (UInt16)obj1 ^ (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is UInt64)
        {
            result = (UInt16)obj1 ^ (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt16 && obj2 is Char)
        {
            result = (UInt16)obj1 ^ (Char)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Byte)
        {
            result = (Int32)obj1 ^ (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is SByte)
        {
            result = (Int32)obj1 ^ (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int16)
        {
            result = (Int32)obj1 ^ (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt16)
        {
            result = (Int32)obj1 ^ (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int32)
        {
            result = (Int32)obj1 ^ (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is UInt32)
        {
            result = (Int32)obj1 ^ (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Int64)
        {
            result = (Int32)obj1 ^ (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int32 && obj2 is Char)
        {
            result = (Int32)obj1 ^ (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Byte)
        {
            result = (UInt32)obj1 ^ (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is SByte)
        {
            result = (UInt32)obj1 ^ (SByte)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int16)
        {
            result = (UInt32)obj1 ^ (Int16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt16)
        {
            result = (UInt32)obj1 ^ (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int32)
        {
            result = (UInt32)obj1 ^ (Int32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt32)
        {
            result = (UInt32)obj1 ^ (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Int64)
        {
            result = (UInt32)obj1 ^ (Int64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is UInt64)
        {
            result = (UInt32)obj1 ^ (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt32 && obj2 is Char)
        {
            result = (UInt32)obj1 ^ (Char)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Byte)
        {
            result = (Int64)obj1 ^ (Byte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is SByte)
        {
            result = (Int64)obj1 ^ (SByte)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int16)
        {
            result = (Int64)obj1 ^ (Int16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt16)
        {
            result = (Int64)obj1 ^ (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int32)
        {
            result = (Int64)obj1 ^ (Int32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is UInt32)
        {
            result = (Int64)obj1 ^ (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Int64)
        {
            result = (Int64)obj1 ^ (Int64)obj2;
            return true;
        }
    
        if(obj1 is Int64 && obj2 is Char)
        {
            result = (Int64)obj1 ^ (Char)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Byte)
        {
            result = (UInt64)obj1 ^ (Byte)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt16)
        {
            result = (UInt64)obj1 ^ (UInt16)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt32)
        {
            result = (UInt64)obj1 ^ (UInt32)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is UInt64)
        {
            result = (UInt64)obj1 ^ (UInt64)obj2;
            return true;
        }
    
        if(obj1 is UInt64 && obj2 is Char)
        {
            result = (UInt64)obj1 ^ (Char)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Byte)
        {
            result = (Char)obj1 ^ (Byte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is SByte)
        {
            result = (Char)obj1 ^ (SByte)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int16)
        {
            result = (Char)obj1 ^ (Int16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt16)
        {
            result = (Char)obj1 ^ (UInt16)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int32)
        {
            result = (Char)obj1 ^ (Int32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt32)
        {
            result = (Char)obj1 ^ (UInt32)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Int64)
        {
            result = (Char)obj1 ^ (Int64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is UInt64)
        {
            result = (Char)obj1 ^ (UInt64)obj2;
            return true;
        }
    
        if(obj1 is Char && obj2 is Char)
        {
            result = (Char)obj1 ^ (Char)obj2;
            return true;
        }
    
        result = null;
        return false;
    }
    
    public static bool TryUnaryNegation(object obj1, out object result)
    {
        Type type1 = obj1.GetType();
    
        if(obj1 is Byte byt)
        {
            result = -byt;
            return true;
        }
    
        if(obj1 is SByte sbyt)
        {
            result = -sbyt;
            return true;
        }
    
        if(obj1 is Int16 in16)
        {
            result = -in16;
            return true;
        }
    
        if(obj1 is UInt16 uin16)
        {
            result = -uin16;
            return true;
        }
    
        if(obj1 is Int32 in32)
        {
            result = -in32;
            return true;
        }
    
        if(obj1 is UInt32 uin32)
        {
            result = -uin32;
            return true;
        }
    
        if(obj1 is Int64 in64)
        {
            result = -in64;
            return true;
        }
    
        if(obj1 is Char chr)
        {
            result = -chr;
            return true;
        }
    
        if(obj1 is Double dbl)
        {
            result = -dbl;
            return true;
        }
    
        if(obj1 is Single sgl)
        {
            result = -sgl;
            return true;
        }
    
        if(obj1 is Decimal dec)
        {
            result = -dec;
            return true;
        }
    
        result = null;
        return false;
    }
    
    public static bool TryUnaryPlus(object obj1, out object result)
    {
        Type type1 = obj1.GetType();
    
        if(obj1 is Byte byt)
        {
            result = +byt;
            return true;
        }
    
        if(obj1 is SByte sbyt)
        {
            result = +sbyt;
            return true;
        }
    
        if(obj1 is Int16 in16)
        {
            result = +in16;
            return true;
        }
    
        if(obj1 is UInt16 uin16)
        {
            result = +uin16;
            return true;
        }
    
        if(obj1 is Int32 in32)
        {
            result = +in32;
            return true;
        }
    
        if(obj1 is UInt32 uin32)
        {
            result = +uin32;
            return true;
        }
    
        if(obj1 is Int64 in64)
        {
            result = +in64;
            return true;
        }
    
        if(obj1 is UInt64 uin64)
        {
            result = +uin64;
            return true;
        }
    
        if(obj1 is Char chr)
        {
            result = +chr;
            return true;
        }
    
        if(obj1 is Double dbl)
        {
            result = +dbl;
            return true;
        }
    
        if(obj1 is Single sgl)
        {
            result = +sgl;
            return true;
        }
    
        if(obj1 is Decimal dec)
        {
            result = +dec;
            return true;
        }
    
        result = null;
        return false;
    }
    
    public static bool TryOnesComplement(object obj1, out object result)
    {
        Type type1 = obj1.GetType();
    
        if(obj1 is Byte byt)
        {
            result = ~byt;
            return true;
        }
    
        if(obj1 is SByte sbyt)
        {
            result = ~sbyt;
            return true;
        }
    
        if(obj1 is Int16 in16)
        {
            result = ~in16;
            return true;
        }
    
        if(obj1 is UInt16 uin16)
        {
            result = ~uin16;
            return true;
        }
    
        if(obj1 is Int32 in32)
        {
            result = ~in32;
            return true;
        }
    
        if(obj1 is UInt32 uin32)
        {
            result = ~uin32;
            return true;
        }
    
        if(obj1 is Int64 in64)
        {
            result = ~in64;
            return true;
        }
    
        if(obj1 is UInt64 uin64)
        {
            result = ~uin64;
            return true;
        }
    
        if(obj1 is Char chr)
        {
            result = ~chr;
            return true;
        }
    
        result = null;
        return false;
    }
    
    public static bool TryIncrement(object obj1, out object result)
    {
        Type type1 = obj1.GetType();
    
        if(obj1 is Byte byt)
        {
            result = ++byt;
            return true;
        }
    
        if(obj1 is SByte sbyt)
        {
            result = ++sbyt;
            return true;
        }
    
        if(obj1 is Int16 in16)
        {
            result = ++in16;
            return true;
        }
    
        if(obj1 is UInt16 uin16)
        {
            result = ++uin16;
            return true;
        }
    
        if(obj1 is Int32 in32)
        {
            result = ++in32;
            return true;
        }
    
        if(obj1 is UInt32 uin32)
        {
            result = ++uin32;
            return true;
        }
    
        if(obj1 is Int64 in64)
        {
            result = ++in64;
            return true;
        }
    
        if(obj1 is UInt64 uin64)
        {
            result = ++uin64;
            return true;
        }
    
        if(obj1 is Char chr)
        {
            result = ++chr;
            return true;
        }
    
        if(obj1 is Double dbl)
        {
            result = ++dbl;
            return true;
        }
    
        if(obj1 is Single sgl)
        {
            result = ++sgl;
            return true;
        }
    
        if(obj1 is Decimal dec)
        {
            result = ++dec;
            return true;
        }
    
        result = null;
        return false;
    }
    
    public static bool TryDecrement(object obj1, out object result)
    {
        Type type1 = obj1.GetType();
    
        if(obj1 is Byte byt)
        {
            result = --byt;
            return true;
        }
    
        if(obj1 is SByte sbyt)
        {
            result = --sbyt;
            return true;
        }
    
        if(obj1 is Int16 in16)
        {
            result = --in16;
            return true;
        }
    
        if(obj1 is UInt16 uin16)
        {
            result = --uin16;
            return true;
        }
    
        if(obj1 is Int32 in32)
        {
            result = --in32;
            return true;
        }
    
        if(obj1 is UInt32 uin32)
        {
            result = --uin32;
            return true;
        }
    
        if(obj1 is Int64 in64)
        {
            result = --in64;
            return true;
        }
    
        if(obj1 is UInt64 uin64)
        {
            result = --uin64;
            return true;
        }
    
        if(obj1 is Char chr)
        {
            result = --chr;
            return true;
        }
    
        if(obj1 is Double dbl)
        {
            result = --dbl;
            return true;
        }
    
        if(obj1 is Single sgl)
        {
            result = --sgl;
            return true;
        }
    
        if(obj1 is Decimal dec)
        {
            result = --dec;
            return true;
        }
    
        result = null;
        return false;
    }
    

}
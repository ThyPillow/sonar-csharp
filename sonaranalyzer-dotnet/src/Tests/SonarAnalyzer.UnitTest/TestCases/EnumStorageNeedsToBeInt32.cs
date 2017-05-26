using System;

namespace MyLibrary
{
    [Flags]
    public enum Days : sbyte // Noncompliant {{Change this enum storage to 'Int32'.}}
//              ^^^^
    {
        None = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        All = Monday | Tuesday | Wednesday | Thursday | Friday
    }

    public enum Test_01 { } // Compliant
    public enum Test_02 : int { } // Compliant
    public enum Test_03 : System.Int32 { } // Compliant

    public enum Test_04 : long { } // Noncompliant
    public enum Test_05 : ulong { } // Noncompliant
}
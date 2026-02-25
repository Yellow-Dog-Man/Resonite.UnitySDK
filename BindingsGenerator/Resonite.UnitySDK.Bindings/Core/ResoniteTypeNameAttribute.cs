using System;
using System.Collections;
using System.Collections.Generic;

public class ResoniteTypeNameAttribute : Attribute
{
    public string TypeName { get; private set; }

    public ResoniteTypeNameAttribute(string typeName)
    {
        TypeName = typeName;
    }
}

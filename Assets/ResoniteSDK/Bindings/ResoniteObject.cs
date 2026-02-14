using ResoniteLink;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public abstract class ResoniteObject
{
    public Dictionary<string, Member> CollectMembers(IConversionContext context)
    {
        var members = new Dictionary<string, Member>();
        CollectMembers(members, context);
        return members;
    }

    public virtual void CollectMembers(Dictionary<string, Member> members, IConversionContext context) { }
}

using ResoniteLink;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ResoniteObject : ScriptableObject
{
    public virtual void CollectMembers(Dictionary<string, Member> members) { }
}

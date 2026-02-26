
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CloudUserRef
// Generated on: čtvrtek 26. února 2026 10:04:49
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CloudUserRef")]
public partial class CloudUserRef : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.User User { get => User_Element.Data; set => User_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> User_Element = new();
public global::System.String _userId { get => _userId_Element.Data; set => _userId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> _userId_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", User_Element.Data.ToResoniteReference(context));
members.Add("_userId", _userId_Element.Data.ToResoniteLinkField());
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LocalVariableSync<>
// Generated on: pátek 13. února 2026 23:23:16
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LocalVariableSync<>")]
public partial class LocalVariableSync<T> : global::FrooxEngine.Component
	

{
    public global::FrooxEngine.UserRef OwnerUser;
public global::FrooxEngine.IField<T> Value;
public global::System.String Variable;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("OwnerUser", new ResoniteLink.SyncObject() { Members = OwnerUser.CollectMembers() });
members.Add("Value", new ResoniteLink.Reference() { });
members.Add("Variable", Variable.ToResoniteLinkField());
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserRefToSyncRefAdapter
// Generated on: čtvrtek 26. února 2026 10:04:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserRefToSyncRefAdapter")]
public partial class UserRefToSyncRefAdapter : global::FrooxEngine.Component

{
    public global::FrooxEngine.UserRef User = new();
public global::FrooxEngine.SyncRef<global::FrooxEngine.User> TargetReference { get => TargetReference_Element.Data; set => TargetReference_Element.Data = value; }
public Field<global::FrooxEngine.RefDrive<global::FrooxEngine.User>, global::FrooxEngine.SyncRef<global::FrooxEngine.User>> TargetReference_Element = new();
public global::System.Boolean WriteBack { get => WriteBack_Element.Data; set => WriteBack_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> WriteBack_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", new ResoniteLink.SyncObject() { Members = User.CollectMembers(context) });
members.Add("TargetReference", TargetReference_Element.Data.ToResoniteReference(context));
members.Add("WriteBack", WriteBack_Element.Data.ToResoniteLinkField());
}

}
}

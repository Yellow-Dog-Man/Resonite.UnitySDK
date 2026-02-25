
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserRefToSyncRefAdapter
// Generated on: středa 25. února 2026 16:14:31
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
    public global::FrooxEngine.UserRef User;
public global::FrooxEngine.SyncRef<global::FrooxEngine.User> TargetReference;
public global::System.Boolean WriteBack;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", new ResoniteLink.SyncObject() { Members = User.CollectMembers(context) });
members.Add("TargetReference", TargetReference.ToResoniteReference(context));
members.Add("WriteBack", WriteBack.ToResoniteLinkField());
}

}
}

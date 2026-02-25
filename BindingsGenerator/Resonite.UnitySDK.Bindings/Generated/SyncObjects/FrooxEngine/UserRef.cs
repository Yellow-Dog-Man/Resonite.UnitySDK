
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserRef
// Generated on: středa 25. února 2026 16:13:02
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserRef")]
public partial class UserRef : global::FrooxEngine.SyncObject, global::FrooxEngine.ISyncRef<global::FrooxEngine.User>, global::FrooxEngine.ISyncRef

{
    public global::FrooxEngine.User User;
public global::System.String _machineId;
public global::System.String _userId;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", User.ToResoniteReference(context));
members.Add("_machineId", _machineId.ToResoniteLinkField());
members.Add("_userId", _userId.ToResoniteLinkField());
}

}
}

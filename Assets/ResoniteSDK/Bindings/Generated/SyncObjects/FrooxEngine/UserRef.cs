
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserRef
// Generated on: pátek 13. února 2026 23:21:32
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserRef")]
public partial class UserRef : global::FrooxEngine.SyncObject, global::FrooxEngine.ISyncRef<global::FrooxEngine.User>, global::FrooxEngine.ISyncRef

{
    public global::FrooxEngine.User User;
public global::System.String _machineId;
public global::System.String _userId;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("User", new ResoniteLink.Reference() { });
members.Add("_machineId", _machineId.ToResoniteLinkField());
members.Add("_userId", _userId.ToResoniteLinkField());
}

}
}

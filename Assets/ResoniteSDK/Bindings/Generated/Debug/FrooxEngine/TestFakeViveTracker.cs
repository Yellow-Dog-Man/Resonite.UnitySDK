
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TestFakeViveTracker
// Generated on: pátek 13. února 2026 5:51:13
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TestFakeViveTracker")]
public partial class TestFakeViveTracker : global::FrooxEngine.Component

{
    public global::System.String Id;
public global::System.Boolean IsTracking;
public global::FrooxEngine.UserRef User;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Id", Id.ToResoniteLinkField());
members.Add("IsTracking", IsTracking.ToResoniteLinkField());
members.Add("User", new ResoniteLink.SyncObject() { Members = User.CollectMembers() });
}

}
}

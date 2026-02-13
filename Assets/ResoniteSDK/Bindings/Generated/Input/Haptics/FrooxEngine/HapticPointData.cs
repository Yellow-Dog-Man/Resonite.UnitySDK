
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HapticPointData
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HapticPointData")]
public partial class HapticPointData : global::FrooxEngine.Component

{
    public global::System.Int32 Index;
public global::FrooxEngine.UserRef User;
public global::System.Single Force;
public global::System.Single Temperature;
public global::System.Single Pain;
public global::System.Single Vibration;
public global::System.Single TotalActivationIntensity;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Index", Index.ToResoniteLinkField());
members.Add("User", new ResoniteLink.SyncObject() { Members = User.CollectMembers() });
members.Add("Force", Force.ToResoniteLinkField());
members.Add("Temperature", Temperature.ToResoniteLinkField());
members.Add("Pain", Pain.ToResoniteLinkField());
members.Add("Vibration", Vibration.ToResoniteLinkField());
members.Add("TotalActivationIntensity", TotalActivationIntensity.ToResoniteLinkField());
}

}
}

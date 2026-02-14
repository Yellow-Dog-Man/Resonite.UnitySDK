
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DirectTagHapticSource
// Generated on: sobota 14. února 2026 8:57:06
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DirectTagHapticSource")]
public partial class DirectTagHapticSource : global::FrooxEngine.Component, global::FrooxEngine.IDirectHapticSource

{
    public global::System.String HapticTag;
public global::System.Single Force;
public global::System.Single Temperature;
public global::System.Single Pain;
public global::System.Single Vibration;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HapticTag", HapticTag.ToResoniteLinkField());
members.Add("Force", Force.ToResoniteLinkField());
members.Add("Temperature", Temperature.ToResoniteLinkField());
members.Add("Pain", Pain.ToResoniteLinkField());
members.Add("Vibration", Vibration.ToResoniteLinkField());
}

}
}

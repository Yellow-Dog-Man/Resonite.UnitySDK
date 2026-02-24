
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabbingSettings
// Generated on: úterý 24. února 2026 18:20:22
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GrabbingSettings")]
public partial class GrabbingSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.GrabbingSettings>

{
    public global::FrooxEngine.InteractionHandler.HandGrabType DefaultHandGrabType;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DefaultHandGrabType", DefaultHandGrabType.ToResoniteLinkField());
}

}
}

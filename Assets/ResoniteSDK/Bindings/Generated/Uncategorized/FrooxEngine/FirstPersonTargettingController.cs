
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FirstPersonTargettingController
// Generated on: úterý 24. února 2026 18:18:56
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FirstPersonTargettingController")]
public partial class FirstPersonTargettingController : global::FrooxEngine.TargettingControllerBase<global::FrooxEngine.ScreenCameraInputs>

{
    public global::System.Single MinVerticalAngle;
public global::System.Single MaxVerticalAngle;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinVerticalAngle", MinVerticalAngle.ToResoniteLinkField());
members.Add("MaxVerticalAngle", MaxVerticalAngle.ToResoniteLinkField());
}

}
}

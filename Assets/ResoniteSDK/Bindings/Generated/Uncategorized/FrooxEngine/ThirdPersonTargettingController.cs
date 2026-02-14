
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ThirdPersonTargettingController
// Generated on: sobota 14. února 2026 8:57:46
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ThirdPersonTargettingController")]
public partial class ThirdPersonTargettingController : global::FrooxEngine.TargettingControllerBase<global::FrooxEngine.ScreenCameraInputs>

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

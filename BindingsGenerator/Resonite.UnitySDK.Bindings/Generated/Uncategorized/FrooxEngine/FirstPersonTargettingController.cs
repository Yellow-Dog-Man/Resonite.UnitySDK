
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FirstPersonTargettingController
// Generated on: čtvrtek 26. února 2026 12:27:26
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FirstPersonTargettingController")]
public partial class FirstPersonTargettingController : global::FrooxEngine.TargettingControllerBase<global::FrooxEngine.ScreenCameraInputs>

{
    public global::System.Single MinVerticalAngle { get => MinVerticalAngle_Element.Data; set => MinVerticalAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinVerticalAngle_Element = new();
public global::System.Single MaxVerticalAngle { get => MaxVerticalAngle_Element.Data; set => MaxVerticalAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxVerticalAngle_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MinVerticalAngle", MinVerticalAngle_Element.ToLinkField(context));
members.Add("MaxVerticalAngle", MaxVerticalAngle_Element.ToLinkField(context));
}

}
}

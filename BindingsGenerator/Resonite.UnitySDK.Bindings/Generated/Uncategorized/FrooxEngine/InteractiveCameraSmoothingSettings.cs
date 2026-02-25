
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraSmoothingSettings
// Generated on: středa 25. února 2026 16:14:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraSmoothingSettings")]
public partial class InteractiveCameraSmoothingSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.InteractiveCameraSmoothingSettings>

{
    public global::System.Single PositionSmoothSpeed;
public global::System.Single AngleSmoothSpeed;
public global::System.Single FramingSmoothSpeed;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PositionSmoothSpeed", PositionSmoothSpeed.ToResoniteLinkField());
members.Add("AngleSmoothSpeed", AngleSmoothSpeed.ToResoniteLinkField());
members.Add("FramingSmoothSpeed", FramingSmoothSpeed.ToResoniteLinkField());
}

}
}

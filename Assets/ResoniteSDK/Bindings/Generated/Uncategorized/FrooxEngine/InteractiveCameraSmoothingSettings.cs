
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraSmoothingSettings
// Generated on: pátek 13. února 2026 23:23:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraSmoothingSettings")]
public partial class InteractiveCameraSmoothingSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.InteractiveCameraSmoothingSettings>

{
    public global::System.Single PositionSmoothSpeed;
public global::System.Single AngleSmoothSpeed;
public global::System.Single FramingSmoothSpeed;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("PositionSmoothSpeed", PositionSmoothSpeed.ToResoniteLinkField());
members.Add("AngleSmoothSpeed", AngleSmoothSpeed.ToResoniteLinkField());
members.Add("FramingSmoothSpeed", FramingSmoothSpeed.ToResoniteLinkField());
}

}
}

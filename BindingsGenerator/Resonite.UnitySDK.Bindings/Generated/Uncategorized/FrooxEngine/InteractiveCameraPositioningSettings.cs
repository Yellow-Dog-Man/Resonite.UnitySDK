
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraPositioningSettings
// Generated on: čtvrtek 26. února 2026 12:28:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraPositioningSettings")]
public partial class InteractiveCameraPositioningSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.InteractiveCameraPositioningSettings>

{
    public global::System.Boolean AvoidOcclusion { get => AvoidOcclusion_Element.Data; set => AvoidOcclusion_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AvoidOcclusion_Element = new();
public global::System.Boolean KeepInWorldSpace { get => KeepInWorldSpace_Element.Data; set => KeepInWorldSpace_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> KeepInWorldSpace_Element = new();
public global::System.Boolean MovementWobble { get => MovementWobble_Element.Data; set => MovementWobble_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> MovementWobble_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AvoidOcclusion", AvoidOcclusion_Element.ToLinkField(context));
members.Add("KeepInWorldSpace", KeepInWorldSpace_Element.ToLinkField(context));
members.Add("MovementWobble", MovementWobble_Element.ToLinkField(context));
}

}
}

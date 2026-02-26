
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TalkVisualizer
// Generated on: čtvrtek 26. února 2026 10:04:48
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TalkVisualizer")]
public partial class TalkVisualizer : global::FrooxEngine.Component

{
    public global::FrooxEngine.RawOutput<global::System.Single> Input { get => Input_Element.Data; set => Input_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.RawOutput<global::System.Single>>, global::FrooxEngine.RawOutput<global::System.Single>> Input_Element = new();
public UnityEngine.ColorX BaseColor { get => BaseColor_Element.Data; set => BaseColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> BaseColor_Element = new();
public global::FrooxEngine.Sync<UnityEngine.ColorX> MaterialColor { get => MaterialColor_Element.Data; set => MaterialColor_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.Sync<UnityEngine.ColorX>>, global::FrooxEngine.Sync<UnityEngine.ColorX>> MaterialColor_Element = new();
public global::FrooxEngine.Sync<global::System.Single> LightIntensity { get => LightIntensity_Element.Data; set => LightIntensity_Element.Data = value; }
public Field<global::FrooxEngine.DriveRef<global::FrooxEngine.Sync<global::System.Single>>, global::FrooxEngine.Sync<global::System.Single>> LightIntensity_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Input", Input_Element.Data.ToResoniteReference(context));
members.Add("BaseColor", BaseColor_Element.Data.ToResoniteLinkField());
members.Add("MaterialColor", MaterialColor_Element.Data.ToResoniteReference(context));
members.Add("LightIntensity", LightIntensity_Element.Data.ToResoniteReference(context));
}

}
}

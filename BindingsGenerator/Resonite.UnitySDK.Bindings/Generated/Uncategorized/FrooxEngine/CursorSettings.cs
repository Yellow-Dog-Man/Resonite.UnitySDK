
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CursorSettings
// Generated on: čtvrtek 26. února 2026 10:04:44
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CursorSettings")]
public partial class CursorSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.CursorSettings>

{
    public global::System.Single BaseCursorSize { get => BaseCursorSize_Element.Data; set => BaseCursorSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BaseCursorSize_Element = new();
public global::System.Single GrabMultiplier { get => GrabMultiplier_Element.Data; set => GrabMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GrabMultiplier_Element = new();
public global::System.Single InteractionMultiplier { get => InteractionMultiplier_Element.Data; set => InteractionMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InteractionMultiplier_Element = new();
public global::System.Single TextMultiplier { get => TextMultiplier_Element.Data; set => TextMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TextMultiplier_Element = new();
public global::System.Single SliderMultiplier { get => SliderMultiplier_Element.Data; set => SliderMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SliderMultiplier_Element = new();
public global::System.Boolean DirectCursorEnabled { get => DirectCursorEnabled_Element.Data; set => DirectCursorEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DirectCursorEnabled_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BaseCursorSize", BaseCursorSize_Element.Data.ToResoniteLinkField());
members.Add("GrabMultiplier", GrabMultiplier_Element.Data.ToResoniteLinkField());
members.Add("InteractionMultiplier", InteractionMultiplier_Element.Data.ToResoniteLinkField());
members.Add("TextMultiplier", TextMultiplier_Element.Data.ToResoniteLinkField());
members.Add("SliderMultiplier", SliderMultiplier_Element.Data.ToResoniteLinkField());
members.Add("DirectCursorEnabled", DirectCursorEnabled_Element.Data.ToResoniteLinkField());
}

}
}

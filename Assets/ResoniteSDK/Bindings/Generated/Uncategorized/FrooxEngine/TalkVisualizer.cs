
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TalkVisualizer
// Generated on: čtvrtek 19. února 2026 8:00:31
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public global::FrooxEngine.RawOutput<global::System.Single> Input;
public UnityEngine.ColorX BaseColor;
public global::FrooxEngine.Sync<UnityEngine.ColorX> MaterialColor;
public global::FrooxEngine.Sync<global::System.Single> LightIntensity;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Input", Input.ToResoniteReference(context));
members.Add("BaseColor", BaseColor.ToResoniteLinkField());
members.Add("MaterialColor", MaterialColor.ToResoniteReference(context));
members.Add("LightIntensity", LightIntensity.ToResoniteReference(context));
}

}
}

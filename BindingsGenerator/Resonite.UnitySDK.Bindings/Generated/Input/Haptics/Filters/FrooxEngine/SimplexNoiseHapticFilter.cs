
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SimplexNoiseHapticFilter
// Generated on: pátek 6. března 2026 14:18:08
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SimplexNoiseHapticFilter")]
public partial class SimplexNoiseHapticFilter : global::FrooxEngine.HapticFilter

{
    public UnityEngine.Vector3 NoiseScale { get => NoiseScale_Element.Data; set => NoiseScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> NoiseScale_Element = new();
public UnityEngine.Vector3 NoiseOffset { get => NoiseOffset_Element.Data; set => NoiseOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> NoiseOffset_Element = new();
public global::System.Single MinValue { get => MinValue_Element.Data; set => MinValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinValue_Element = new();
public global::System.Single MaxValue { get => MaxValue_Element.Data; set => MaxValue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxValue_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("NoiseScale", NoiseScale_Element.ToLinkField(context));
members.Add("NoiseOffset", NoiseOffset_Element.ToLinkField(context));
members.Add("MinValue", MinValue_Element.ToLinkField(context));
members.Add("MaxValue", MaxValue_Element.ToLinkField(context));
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugHapticPoint
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugHapticPoint")]
public partial class DebugHapticPoint : global::FrooxEngine.Component, global::FrooxEngine.IHapticSource

{
    public global::System.Single Intensity { get => Intensity_Element.Data; set => Intensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Intensity_Element = new();
public global::System.Int32 Index { get => Index_Element.Data; set => Index_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Index_Element = new();
public global::System.String Position { get => Position_Element.Data; set => Position_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> Position_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Intensity", Intensity_Element.ToLinkField(context));
members.Add("Index", Index_Element.ToLinkField(context));
members.Add("Position", Position_Element.ToLinkField(context));
}

}
}

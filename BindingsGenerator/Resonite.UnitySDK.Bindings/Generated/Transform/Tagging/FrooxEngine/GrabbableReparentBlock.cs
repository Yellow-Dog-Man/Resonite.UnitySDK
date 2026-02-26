
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabbableReparentBlock
// Generated on: čtvrtek 26. února 2026 12:28:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GrabbableReparentBlock")]
public partial class GrabbableReparentBlock : global::FrooxEngine.Component, global::FrooxEngine.IGrabbableReparentBlock, global::FrooxEngine.IInteractionBlock

{
    public global::System.Boolean DontReparent { get => DontReparent_Element.Data; set => DontReparent_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DontReparent_Element = new();
public global::System.Int32 MaxDepth { get => MaxDepth_Element.Data; set => MaxDepth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MaxDepth_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DontReparent", DontReparent_Element.ToLinkField(context));
members.Add("MaxDepth", MaxDepth_Element.ToLinkField(context));
}

}
}

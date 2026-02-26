
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioFilterBlendWrapper
// Generated on: čtvrtek 26. února 2026 12:26:52
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioFilterBlendWrapper")]
public partial class AudioFilterBlendWrapper : global::FrooxEngine.AudioDSP_Effect

{
    public global::System.Single BlendWeight { get => BlendWeight_Element.Data; set => BlendWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BlendWeight_Element = new();
public global::FrooxEngine.AudioDSP_Effect NestedFilter { get => NestedFilter_Element.Data; set => NestedFilter_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.AudioDSP_Effect>, global::FrooxEngine.AudioDSP_Effect> NestedFilter_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BlendWeight", BlendWeight_Element.ToLinkField(context));
members.Add("NestedFilter", NestedFilter_Element.ToLinkReference(context));
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AvatarFacetAnchor
// Generated on: čtvrtek 26. února 2026 15:09:16
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AvatarFacetAnchor")]
public partial class AvatarFacetAnchor : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::FrooxEngine.FacetAnchorPoint FacetAnchorPoint { get => FacetAnchorPoint_Element.Data; set => FacetAnchorPoint_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.FacetAnchorPoint>, global::FrooxEngine.FacetAnchorPoint> FacetAnchorPoint_Element = new();
public global::System.Nullable<global::System.Boolean> OverrideState { get => OverrideState_Element.Data; set => OverrideState_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Boolean>>, global::System.Nullable<global::System.Boolean>> OverrideState_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("FacetAnchorPoint", FacetAnchorPoint_Element.ToLinkField(context));
members.Add("OverrideState", OverrideState_Element.ToLinkField(context));
}

}
}

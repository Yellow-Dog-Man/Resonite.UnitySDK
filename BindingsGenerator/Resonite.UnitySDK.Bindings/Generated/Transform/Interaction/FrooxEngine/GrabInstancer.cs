
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabInstancer
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GrabInstancer")]
public partial class GrabInstancer : global::FrooxEngine.GrabInstancerBase, global::FrooxEngine.IGrabbable, global::FrooxEngine.IInteractionTarget

{
    public global::System.Boolean Physical { get => Physical_Element.Data; set => Physical_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Physical_Element = new();
public global::System.Int32 GrabPriority { get => GrabPriority_Element.Data; set => GrabPriority_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> GrabPriority_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Physical", Physical_Element.ToLinkField(context));
members.Add("GrabPriority", GrabPriority_Element.ToLinkField(context));
}

}
}

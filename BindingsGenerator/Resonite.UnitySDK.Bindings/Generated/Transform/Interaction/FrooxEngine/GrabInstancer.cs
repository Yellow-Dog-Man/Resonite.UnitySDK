
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GrabInstancer
// Generated on: středa 25. února 2026 16:14:31
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GrabInstancer")]
public partial class GrabInstancer : global::FrooxEngine.GrabInstancerBase, global::FrooxEngine.IGrabbable, global::FrooxEngine.IInteractionTarget

{
    public global::System.Boolean Physical;
public global::System.Int32 GrabPriority;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Physical", Physical.ToResoniteLinkField());
members.Add("GrabPriority", GrabPriority.ToResoniteLinkField());
}

}
}

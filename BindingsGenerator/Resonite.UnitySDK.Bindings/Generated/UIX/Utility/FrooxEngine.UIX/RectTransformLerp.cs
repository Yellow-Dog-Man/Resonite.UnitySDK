
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.RectTransformLerp
// Generated on: čtvrtek 26. února 2026 12:28:09
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.RectTransformLerp")]
public partial class RectTransformLerp : global::FrooxEngine.UIX.UIController

{
    public global::System.Single Lerp { get => Lerp_Element.Data; set => Lerp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Lerp_Element = new();
public global::FrooxEngine.UIX.RectTransform SourceRect { get => SourceRect_Element.Data; set => SourceRect_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.RectTransform>, global::FrooxEngine.UIX.RectTransform> SourceRect_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Lerp", Lerp_Element.ToLinkField(context));
members.Add("SourceRect", SourceRect_Element.ToLinkReference(context));
}

}
}

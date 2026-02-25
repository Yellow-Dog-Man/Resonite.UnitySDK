
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ProgressBar
// Generated on: středa 25. února 2026 16:14:33
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.ProgressBar")]
public partial class ProgressBar : global::FrooxEngine.Component

{
    public global::System.Single Progress;
public UnityEngine.Vector2 AnchorMinOffset;
public UnityEngine.Vector2 AnchorMaxOffset;
public global::FrooxEngine.IField<UnityEngine.Vector2> AnchorMin;
public global::FrooxEngine.IField<UnityEngine.Vector2> AnchorMax;
public global::System.Single Power;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Progress", Progress.ToResoniteLinkField());
members.Add("AnchorMinOffset", AnchorMinOffset.ToResoniteLinkField());
members.Add("AnchorMaxOffset", AnchorMaxOffset.ToResoniteLinkField());
members.Add("AnchorMin", AnchorMin.ToResoniteReference(context));
members.Add("AnchorMax", AnchorMax.ToResoniteReference(context));
members.Add("Power", Power.ToResoniteLinkField());
}

}
}

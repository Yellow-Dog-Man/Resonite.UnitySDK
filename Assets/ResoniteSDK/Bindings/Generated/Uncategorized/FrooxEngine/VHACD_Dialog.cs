
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VHACD_Dialog
// Generated on: sobota 14. února 2026 8:58:48
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VHACD_Dialog")]
public partial class VHACD_Dialog : global::FrooxEngine.Component, global::FrooxEngine.IDeveloperInterface

{
    public global::FrooxEngine.MeshCollider TargetCollider;
public global::FrooxEngine.UIX.Checkbox MergeDoubles;
public global::FrooxEngine.IntTextEditorParser Resolution;
public global::FrooxEngine.IntTextEditorParser Depth;
public global::FrooxEngine.FloatTextEditorParser Concavity;
public global::FrooxEngine.IntTextEditorParser PlaneDownsampling;
public global::FrooxEngine.IntTextEditorParser ConvexHullDownsampling;
public global::FrooxEngine.FloatTextEditorParser Alpha;
public global::FrooxEngine.FloatTextEditorParser Beta;
public global::FrooxEngine.FloatTextEditorParser Gamma;
public global::FrooxEngine.FloatTextEditorParser Delta;
public global::FrooxEngine.UIX.Checkbox PCA;
public global::Elements.Assets.VHACDInterface.DecompositionMode Mode;
public global::FrooxEngine.IntTextEditorParser MaxVerticesPerHull;
public global::FrooxEngine.FloatTextEditorParser MinVolumePerHull;
public global::FrooxEngine.UIX.Checkbox ConvexHullApproximation;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetCollider", TargetCollider.ToResoniteReference(context));
members.Add("MergeDoubles", MergeDoubles.ToResoniteReference(context));
members.Add("Resolution", Resolution.ToResoniteReference(context));
members.Add("Depth", Depth.ToResoniteReference(context));
members.Add("Concavity", Concavity.ToResoniteReference(context));
members.Add("PlaneDownsampling", PlaneDownsampling.ToResoniteReference(context));
members.Add("ConvexHullDownsampling", ConvexHullDownsampling.ToResoniteReference(context));
members.Add("Alpha", Alpha.ToResoniteReference(context));
members.Add("Beta", Beta.ToResoniteReference(context));
members.Add("Gamma", Gamma.ToResoniteReference(context));
members.Add("Delta", Delta.ToResoniteReference(context));
members.Add("PCA", PCA.ToResoniteReference(context));
members.Add("Mode", Mode.ToResoniteLinkField());
members.Add("MaxVerticesPerHull", MaxVerticesPerHull.ToResoniteReference(context));
members.Add("MinVolumePerHull", MinVolumePerHull.ToResoniteReference(context));
members.Add("ConvexHullApproximation", ConvexHullApproximation.ToResoniteReference(context));
}

}
}

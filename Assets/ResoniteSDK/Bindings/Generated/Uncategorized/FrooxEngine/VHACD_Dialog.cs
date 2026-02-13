
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VHACD_Dialog
// Generated on: pátek 13. února 2026 23:23:19
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetCollider", new ResoniteLink.Reference() { });
members.Add("MergeDoubles", new ResoniteLink.Reference() { });
members.Add("Resolution", new ResoniteLink.Reference() { });
members.Add("Depth", new ResoniteLink.Reference() { });
members.Add("Concavity", new ResoniteLink.Reference() { });
members.Add("PlaneDownsampling", new ResoniteLink.Reference() { });
members.Add("ConvexHullDownsampling", new ResoniteLink.Reference() { });
members.Add("Alpha", new ResoniteLink.Reference() { });
members.Add("Beta", new ResoniteLink.Reference() { });
members.Add("Gamma", new ResoniteLink.Reference() { });
members.Add("Delta", new ResoniteLink.Reference() { });
members.Add("PCA", new ResoniteLink.Reference() { });
members.Add("Mode", Mode.ToResoniteLinkField());
members.Add("MaxVerticesPerHull", new ResoniteLink.Reference() { });
members.Add("MinVolumePerHull", new ResoniteLink.Reference() { });
members.Add("ConvexHullApproximation", new ResoniteLink.Reference() { });
}

}
}

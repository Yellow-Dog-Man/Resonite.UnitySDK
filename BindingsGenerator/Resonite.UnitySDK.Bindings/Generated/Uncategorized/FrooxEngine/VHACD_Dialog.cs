
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VHACD_Dialog
// Generated on: čtvrtek 26. února 2026 10:04:49
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VHACD_Dialog")]
public partial class VHACD_Dialog : global::FrooxEngine.Component, global::FrooxEngine.IDeveloperInterface

{
    public global::FrooxEngine.MeshCollider TargetCollider { get => TargetCollider_Element.Data; set => TargetCollider_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.MeshCollider>, global::FrooxEngine.MeshCollider> TargetCollider_Element = new();
public global::FrooxEngine.UIX.Checkbox MergeDoubles { get => MergeDoubles_Element.Data; set => MergeDoubles_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> MergeDoubles_Element = new();
public global::FrooxEngine.IntTextEditorParser Resolution { get => Resolution_Element.Data; set => Resolution_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IntTextEditorParser>, global::FrooxEngine.IntTextEditorParser> Resolution_Element = new();
public global::FrooxEngine.IntTextEditorParser Depth { get => Depth_Element.Data; set => Depth_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IntTextEditorParser>, global::FrooxEngine.IntTextEditorParser> Depth_Element = new();
public global::FrooxEngine.FloatTextEditorParser Concavity { get => Concavity_Element.Data; set => Concavity_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.FloatTextEditorParser>, global::FrooxEngine.FloatTextEditorParser> Concavity_Element = new();
public global::FrooxEngine.IntTextEditorParser PlaneDownsampling { get => PlaneDownsampling_Element.Data; set => PlaneDownsampling_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IntTextEditorParser>, global::FrooxEngine.IntTextEditorParser> PlaneDownsampling_Element = new();
public global::FrooxEngine.IntTextEditorParser ConvexHullDownsampling { get => ConvexHullDownsampling_Element.Data; set => ConvexHullDownsampling_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IntTextEditorParser>, global::FrooxEngine.IntTextEditorParser> ConvexHullDownsampling_Element = new();
public global::FrooxEngine.FloatTextEditorParser Alpha { get => Alpha_Element.Data; set => Alpha_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.FloatTextEditorParser>, global::FrooxEngine.FloatTextEditorParser> Alpha_Element = new();
public global::FrooxEngine.FloatTextEditorParser Beta { get => Beta_Element.Data; set => Beta_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.FloatTextEditorParser>, global::FrooxEngine.FloatTextEditorParser> Beta_Element = new();
public global::FrooxEngine.FloatTextEditorParser Gamma { get => Gamma_Element.Data; set => Gamma_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.FloatTextEditorParser>, global::FrooxEngine.FloatTextEditorParser> Gamma_Element = new();
public global::FrooxEngine.FloatTextEditorParser Delta { get => Delta_Element.Data; set => Delta_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.FloatTextEditorParser>, global::FrooxEngine.FloatTextEditorParser> Delta_Element = new();
public global::FrooxEngine.UIX.Checkbox PCA { get => PCA_Element.Data; set => PCA_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> PCA_Element = new();
public global::Elements.Assets.VHACDInterface.DecompositionMode Mode { get => Mode_Element.Data; set => Mode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Assets.VHACDInterface.DecompositionMode>, global::Elements.Assets.VHACDInterface.DecompositionMode> Mode_Element = new();
public global::FrooxEngine.IntTextEditorParser MaxVerticesPerHull { get => MaxVerticesPerHull_Element.Data; set => MaxVerticesPerHull_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IntTextEditorParser>, global::FrooxEngine.IntTextEditorParser> MaxVerticesPerHull_Element = new();
public global::FrooxEngine.FloatTextEditorParser MinVolumePerHull { get => MinVolumePerHull_Element.Data; set => MinVolumePerHull_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.FloatTextEditorParser>, global::FrooxEngine.FloatTextEditorParser> MinVolumePerHull_Element = new();
public global::FrooxEngine.UIX.Checkbox ConvexHullApproximation { get => ConvexHullApproximation_Element.Data; set => ConvexHullApproximation_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> ConvexHullApproximation_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetCollider", TargetCollider_Element.Data.ToResoniteReference(context));
members.Add("MergeDoubles", MergeDoubles_Element.Data.ToResoniteReference(context));
members.Add("Resolution", Resolution_Element.Data.ToResoniteReference(context));
members.Add("Depth", Depth_Element.Data.ToResoniteReference(context));
members.Add("Concavity", Concavity_Element.Data.ToResoniteReference(context));
members.Add("PlaneDownsampling", PlaneDownsampling_Element.Data.ToResoniteReference(context));
members.Add("ConvexHullDownsampling", ConvexHullDownsampling_Element.Data.ToResoniteReference(context));
members.Add("Alpha", Alpha_Element.Data.ToResoniteReference(context));
members.Add("Beta", Beta_Element.Data.ToResoniteReference(context));
members.Add("Gamma", Gamma_Element.Data.ToResoniteReference(context));
members.Add("Delta", Delta_Element.Data.ToResoniteReference(context));
members.Add("PCA", PCA_Element.Data.ToResoniteReference(context));
members.Add("Mode", Mode_Element.Data.ToResoniteLinkField());
members.Add("MaxVerticesPerHull", MaxVerticesPerHull_Element.Data.ToResoniteReference(context));
members.Add("MinVolumePerHull", MinVolumePerHull_Element.Data.ToResoniteReference(context));
members.Add("ConvexHullApproximation", ConvexHullApproximation_Element.Data.ToResoniteReference(context));
}

}
}

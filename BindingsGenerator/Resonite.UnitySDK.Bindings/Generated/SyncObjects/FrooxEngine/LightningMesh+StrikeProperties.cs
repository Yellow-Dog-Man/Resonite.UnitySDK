
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LightningMesh+StrikeProperties
// Generated on: čtvrtek 26. února 2026 15:07:55
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
    public partial class LightningMesh
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LightningMesh+StrikeProperties")]
public partial class StrikeProperties : global::FrooxEngine.SyncObject

{
    public global::System.Int32 Segments { get => Segments_Element.Data; set => Segments_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Segments_Element = new();
public global::System.Single StartWidth { get => StartWidth_Element.Data; set => StartWidth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StartWidth_Element = new();
public global::System.Single EndWidth { get => EndWidth_Element.Data; set => EndWidth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EndWidth_Element = new();
public global::System.Single MinOffset { get => MinOffset_Element.Data; set => MinOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinOffset_Element = new();
public global::System.Single MaxOffset { get => MaxOffset_Element.Data; set => MaxOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxOffset_Element = new();
public global::System.Int32 ChildCount { get => ChildCount_Element.Data; set => ChildCount_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> ChildCount_Element = new();
public global::System.Single MinChildTargetDistanceRatio { get => MinChildTargetDistanceRatio_Element.Data; set => MinChildTargetDistanceRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinChildTargetDistanceRatio_Element = new();
public global::System.Single MaxChildTargetDistanceRatio { get => MaxChildTargetDistanceRatio_Element.Data; set => MaxChildTargetDistanceRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxChildTargetDistanceRatio_Element = new();
public global::System.Single MinChildTargetOffset { get => MinChildTargetOffset_Element.Data; set => MinChildTargetOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinChildTargetOffset_Element = new();
public global::System.Single MaxChildTargetOffset { get => MaxChildTargetOffset_Element.Data; set => MaxChildTargetOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxChildTargetOffset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Segments", Segments_Element.ToLinkField(context));
members.Add("StartWidth", StartWidth_Element.ToLinkField(context));
members.Add("EndWidth", EndWidth_Element.ToLinkField(context));
members.Add("MinOffset", MinOffset_Element.ToLinkField(context));
members.Add("MaxOffset", MaxOffset_Element.ToLinkField(context));
members.Add("ChildCount", ChildCount_Element.ToLinkField(context));
members.Add("MinChildTargetDistanceRatio", MinChildTargetDistanceRatio_Element.ToLinkField(context));
members.Add("MaxChildTargetDistanceRatio", MaxChildTargetDistanceRatio_Element.ToLinkField(context));
members.Add("MinChildTargetOffset", MinChildTargetOffset_Element.ToLinkField(context));
members.Add("MaxChildTargetOffset", MaxChildTargetOffset_Element.ToLinkField(context));
}

}
            }
}

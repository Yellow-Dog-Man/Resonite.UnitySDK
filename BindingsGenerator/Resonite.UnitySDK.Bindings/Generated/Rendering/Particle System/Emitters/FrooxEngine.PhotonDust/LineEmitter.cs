
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LineEmitter
// Generated on: čtvrtek 26. února 2026 10:04:38
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.PhotonDust
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotonDust.LineEmitter")]
public partial class LineEmitter : global::FrooxEngine.PhotonDust.ParticleEmitter<global::System.Object>

{
    public UnityEngine.Vector3 Point0 { get => Point0_Element.Data; set => Point0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Point0_Element = new();
public UnityEngine.Vector3 Point1 { get => Point1_Element.Data; set => Point1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Point1_Element = new();
public UnityEngine.ColorX Color0 { get => Color0_Element.Data; set => Color0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color0_Element = new();
public UnityEngine.ColorX Color1 { get => Color1_Element.Data; set => Color1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color1_Element = new();
public global::PhotonDust.LineEmitterDirection DirectionMode { get => DirectionMode_Element.Data; set => DirectionMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::PhotonDust.LineEmitterDirection>, global::PhotonDust.LineEmitterDirection> DirectionMode_Element = new();
public UnityEngine.Vector3 Direction0 { get => Direction0_Element.Data; set => Direction0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Direction0_Element = new();
public UnityEngine.Vector3 Direction1 { get => Direction1_Element.Data; set => Direction1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Direction1_Element = new();
public UnityEngine.Vector3 UpDirection { get => UpDirection_Element.Data; set => UpDirection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> UpDirection_Element = new();
public global::System.Single RandomDirectionWeight { get => RandomDirectionWeight_Element.Data; set => RandomDirectionWeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RandomDirectionWeight_Element = new();
public UnityEngine.Matrix3x3 DirectionPostTransform { get => DirectionPostTransform_Element.Data; set => DirectionPostTransform_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Matrix3x3>, UnityEngine.Matrix3x3> DirectionPostTransform_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Point0", Point0_Element.Data.ToResoniteLinkField());
members.Add("Point1", Point1_Element.Data.ToResoniteLinkField());
members.Add("Color0", Color0_Element.Data.ToResoniteLinkField());
members.Add("Color1", Color1_Element.Data.ToResoniteLinkField());
members.Add("DirectionMode", DirectionMode_Element.Data.ToResoniteLinkField());
members.Add("Direction0", Direction0_Element.Data.ToResoniteLinkField());
members.Add("Direction1", Direction1_Element.Data.ToResoniteLinkField());
members.Add("UpDirection", UpDirection_Element.Data.ToResoniteLinkField());
members.Add("RandomDirectionWeight", RandomDirectionWeight_Element.Data.ToResoniteLinkField());
members.Add("DirectionPostTransform", DirectionPostTransform_Element.Data.ToResoniteLinkField());
}

}
}

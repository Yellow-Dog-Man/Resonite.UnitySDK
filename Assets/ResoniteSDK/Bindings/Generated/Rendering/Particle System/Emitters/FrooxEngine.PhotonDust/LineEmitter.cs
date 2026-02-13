
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotonDust.LineEmitter
// Generated on: pátek 13. února 2026 23:23:05
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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
    public UnityEngine.Vector3 Point0;
public UnityEngine.Vector3 Point1;
public UnityEngine.ColorX Color0;
public UnityEngine.ColorX Color1;
public global::PhotonDust.LineEmitterDirection DirectionMode;
public UnityEngine.Vector3 Direction0;
public UnityEngine.Vector3 Direction1;
public UnityEngine.Vector3 UpDirection;
public global::System.Single RandomDirectionWeight;
public UnityEngine.Matrix3x3 DirectionPostTransform;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Point0", Point0.ToResoniteLinkField());
members.Add("Point1", Point1.ToResoniteLinkField());
members.Add("Color0", Color0.ToResoniteLinkField());
members.Add("Color1", Color1.ToResoniteLinkField());
members.Add("DirectionMode", DirectionMode.ToResoniteLinkField());
members.Add("Direction0", Direction0.ToResoniteLinkField());
members.Add("Direction1", Direction1.ToResoniteLinkField());
members.Add("UpDirection", UpDirection.ToResoniteLinkField());
members.Add("RandomDirectionWeight", RandomDirectionWeight.ToResoniteLinkField());
members.Add("DirectionPostTransform", DirectionPostTransform.ToResoniteLinkField());
}

}
}

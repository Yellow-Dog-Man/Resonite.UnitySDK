
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyGlowCircle
// Generated on: pátek 13. února 2026 23:23:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyGlowCircle")]
public partial class LegacyGlowCircle : global::FrooxEngine.Component

{
    public global::System.Single Radius;
public global::System.Single Height;
public UnityEngine.ColorX Color;
public global::FrooxEngine.IField<UnityEngine.Vector3> _cylinderOffset;
public global::FrooxEngine.IField<global::System.Single> _cylinderRadius;
public global::FrooxEngine.IField<global::System.Single> _cylinderHeight;
public global::FrooxEngine.IField<UnityEngine.Vector2> _circleQuadSize;
public global::FrooxEngine.IField<UnityEngine.ColorX> _circleTint;
public global::FrooxEngine.IField<UnityEngine.ColorX> _cylinderTint;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("Height", Height.ToResoniteLinkField());
members.Add("Color", Color.ToResoniteLinkField());
members.Add("_cylinderOffset", new ResoniteLink.Reference() { });
members.Add("_cylinderRadius", new ResoniteLink.Reference() { });
members.Add("_cylinderHeight", new ResoniteLink.Reference() { });
members.Add("_circleQuadSize", new ResoniteLink.Reference() { });
members.Add("_circleTint", new ResoniteLink.Reference() { });
members.Add("_cylinderTint", new ResoniteLink.Reference() { });
}

}
}

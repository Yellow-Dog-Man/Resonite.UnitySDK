
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyGlowCircle
// Generated on: středa 25. února 2026 16:14:19
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("Height", Height.ToResoniteLinkField());
members.Add("Color", Color.ToResoniteLinkField());
members.Add("_cylinderOffset", _cylinderOffset.ToResoniteReference(context));
members.Add("_cylinderRadius", _cylinderRadius.ToResoniteReference(context));
members.Add("_cylinderHeight", _cylinderHeight.ToResoniteReference(context));
members.Add("_circleQuadSize", _circleQuadSize.ToResoniteReference(context));
members.Add("_circleTint", _circleTint.ToResoniteReference(context));
members.Add("_cylinderTint", _cylinderTint.ToResoniteReference(context));
}

}
}

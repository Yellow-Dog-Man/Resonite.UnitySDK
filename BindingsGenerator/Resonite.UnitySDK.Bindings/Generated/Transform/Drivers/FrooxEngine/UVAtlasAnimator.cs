
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UVAtlasAnimator
// Generated on: čtvrtek 26. února 2026 10:04:42
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UVAtlasAnimator")]
public partial class UVAtlasAnimator : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Vector2> ScaleField { get => ScaleField_Element.Data; set => ScaleField_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> ScaleField_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> OffsetField { get => OffsetField_Element.Data; set => OffsetField_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> OffsetField_Element = new();
public global::FrooxEngine.AtlasInfo AtlasInfo { get => AtlasInfo_Element.Data; set => AtlasInfo_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.AtlasInfo>, global::FrooxEngine.AtlasInfo> AtlasInfo_Element = new();
public global::System.Int32 Frame { get => Frame_Element.Data; set => Frame_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Frame_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ScaleField", ScaleField_Element.Data.ToResoniteReference(context));
members.Add("OffsetField", OffsetField_Element.Data.ToResoniteReference(context));
members.Add("AtlasInfo", AtlasInfo_Element.Data.ToResoniteReference(context));
members.Add("Frame", Frame_Element.Data.ToResoniteLinkField());
}

}
}

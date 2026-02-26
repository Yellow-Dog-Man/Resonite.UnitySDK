
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SingleShapeCharacterControllerManager
// Generated on: čtvrtek 26. února 2026 10:03:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SingleShapeCharacterControllerManager")]
public partial class SingleShapeCharacterControllerManager : global::FrooxEngine.Component

{
    public global::System.Boolean UseUserHeadHeightWhenAvailable { get => UseUserHeadHeightWhenAvailable_Element.Data; set => UseUserHeadHeightWhenAvailable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseUserHeadHeightWhenAvailable_Element = new();
public global::System.Single HeadHeightOffset { get => HeadHeightOffset_Element.Data; set => HeadHeightOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HeadHeightOffset_Element = new();
public global::System.Single CrouchTargetWidth { get => CrouchTargetWidth_Element.Data; set => CrouchTargetWidth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CrouchTargetWidth_Element = new();
public global::System.Single CrouchStart { get => CrouchStart_Element.Data; set => CrouchStart_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CrouchStart_Element = new();
public global::System.Single CrouchEnd { get => CrouchEnd_Element.Data; set => CrouchEnd_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CrouchEnd_Element = new();
public global::System.Single DefaultHeight { get => DefaultHeight_Element.Data; set => DefaultHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DefaultHeight_Element = new();
public global::System.Single DefaultWidth { get => DefaultWidth_Element.Data; set => DefaultWidth_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DefaultWidth_Element = new();
public global::System.Boolean RootAtBottom { get => RootAtBottom_Element.Data; set => RootAtBottom_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> RootAtBottom_Element = new();
public global::FrooxEngine.IField<global::System.Single> TargetHeight { get => TargetHeight_Element.Data; set => TargetHeight_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> TargetHeight_Element = new();
public global::FrooxEngine.IField<global::System.Single> TargetWidth { get => TargetWidth_Element.Data; set => TargetWidth_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> TargetWidth_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> TargetOffset { get => TargetOffset_Element.Data; set => TargetOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> TargetOffset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseUserHeadHeightWhenAvailable", UseUserHeadHeightWhenAvailable_Element.Data.ToResoniteLinkField());
members.Add("HeadHeightOffset", HeadHeightOffset_Element.Data.ToResoniteLinkField());
members.Add("CrouchTargetWidth", CrouchTargetWidth_Element.Data.ToResoniteLinkField());
members.Add("CrouchStart", CrouchStart_Element.Data.ToResoniteLinkField());
members.Add("CrouchEnd", CrouchEnd_Element.Data.ToResoniteLinkField());
members.Add("DefaultHeight", DefaultHeight_Element.Data.ToResoniteLinkField());
members.Add("DefaultWidth", DefaultWidth_Element.Data.ToResoniteLinkField());
members.Add("RootAtBottom", RootAtBottom_Element.Data.ToResoniteLinkField());
members.Add("TargetHeight", TargetHeight_Element.Data.ToResoniteReference(context));
members.Add("TargetWidth", TargetWidth_Element.Data.ToResoniteReference(context));
members.Add("TargetOffset", TargetOffset_Element.Data.ToResoniteReference(context));
}

}
}

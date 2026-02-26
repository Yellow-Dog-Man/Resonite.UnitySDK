
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UnwrappableBoxDriver
// Generated on: čtvrtek 26. února 2026 10:04:41
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UnwrappableBoxDriver")]
public partial class UnwrappableBoxDriver : global::FrooxEngine.Component

{
    public global::System.Single Unwrap { get => Unwrap_Element.Data; set => Unwrap_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Unwrap_Element = new();
public global::System.Single SideSize { get => SideSize_Element.Data; set => SideSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SideSize_Element = new();
public global::System.Boolean ScaleContent { get => ScaleContent_Element.Data; set => ScaleContent_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ScaleContent_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _side0rotation { get => _side0rotation_Element.Data; set => _side0rotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _side0rotation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _side1rotation { get => _side1rotation_Element.Data; set => _side1rotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _side1rotation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _side2rotation { get => _side2rotation_Element.Data; set => _side2rotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _side2rotation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _side3rotation { get => _side3rotation_Element.Data; set => _side3rotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _side3rotation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Quaternion> _topRotation { get => _topRotation_Element.Data; set => _topRotation_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Quaternion>, global::FrooxEngine.IField<UnityEngine.Quaternion>> _topRotation_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _side0offset { get => _side0offset_Element.Data; set => _side0offset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _side0offset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _side1offset { get => _side1offset_Element.Data; set => _side1offset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _side1offset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _side2offset { get => _side2offset_Element.Data; set => _side2offset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _side2offset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _side3offset { get => _side3offset_Element.Data; set => _side3offset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _side3offset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _topOffset { get => _topOffset_Element.Data; set => _topOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _topOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _side0contentOffset { get => _side0contentOffset_Element.Data; set => _side0contentOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _side0contentOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _side1contentOffset { get => _side1contentOffset_Element.Data; set => _side1contentOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _side1contentOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _side2contentOffset { get => _side2contentOffset_Element.Data; set => _side2contentOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _side2contentOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _side3contentOffset { get => _side3contentOffset_Element.Data; set => _side3contentOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _side3contentOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _topContentOffset { get => _topContentOffset_Element.Data; set => _topContentOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _topContentOffset_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _side0contentScale { get => _side0contentScale_Element.Data; set => _side0contentScale_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _side0contentScale_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _side1contentScale { get => _side1contentScale_Element.Data; set => _side1contentScale_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _side1contentScale_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _side2contentScale { get => _side2contentScale_Element.Data; set => _side2contentScale_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _side2contentScale_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _side3contentScale { get => _side3contentScale_Element.Data; set => _side3contentScale_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _side3contentScale_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _bottomContentScale { get => _bottomContentScale_Element.Data; set => _bottomContentScale_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _bottomContentScale_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _topContentScale { get => _topContentScale_Element.Data; set => _topContentScale_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _topContentScale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Unwrap", Unwrap_Element.Data.ToResoniteLinkField());
members.Add("SideSize", SideSize_Element.Data.ToResoniteLinkField());
members.Add("ScaleContent", ScaleContent_Element.Data.ToResoniteLinkField());
members.Add("_side0rotation", _side0rotation_Element.Data.ToResoniteReference(context));
members.Add("_side1rotation", _side1rotation_Element.Data.ToResoniteReference(context));
members.Add("_side2rotation", _side2rotation_Element.Data.ToResoniteReference(context));
members.Add("_side3rotation", _side3rotation_Element.Data.ToResoniteReference(context));
members.Add("_topRotation", _topRotation_Element.Data.ToResoniteReference(context));
members.Add("_side0offset", _side0offset_Element.Data.ToResoniteReference(context));
members.Add("_side1offset", _side1offset_Element.Data.ToResoniteReference(context));
members.Add("_side2offset", _side2offset_Element.Data.ToResoniteReference(context));
members.Add("_side3offset", _side3offset_Element.Data.ToResoniteReference(context));
members.Add("_topOffset", _topOffset_Element.Data.ToResoniteReference(context));
members.Add("_side0contentOffset", _side0contentOffset_Element.Data.ToResoniteReference(context));
members.Add("_side1contentOffset", _side1contentOffset_Element.Data.ToResoniteReference(context));
members.Add("_side2contentOffset", _side2contentOffset_Element.Data.ToResoniteReference(context));
members.Add("_side3contentOffset", _side3contentOffset_Element.Data.ToResoniteReference(context));
members.Add("_topContentOffset", _topContentOffset_Element.Data.ToResoniteReference(context));
members.Add("_side0contentScale", _side0contentScale_Element.Data.ToResoniteReference(context));
members.Add("_side1contentScale", _side1contentScale_Element.Data.ToResoniteReference(context));
members.Add("_side2contentScale", _side2contentScale_Element.Data.ToResoniteReference(context));
members.Add("_side3contentScale", _side3contentScale_Element.Data.ToResoniteReference(context));
members.Add("_bottomContentScale", _bottomContentScale_Element.Data.ToResoniteReference(context));
members.Add("_topContentScale", _topContentScale_Element.Data.ToResoniteReference(context));
}

}
}

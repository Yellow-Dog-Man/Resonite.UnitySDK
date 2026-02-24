
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UnwrappableBoxDriver
// Generated on: úterý 24. února 2026 18:20:15
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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
    public global::System.Single Unwrap;
public global::System.Single SideSize;
public global::System.Boolean ScaleContent;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _side0rotation;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _side1rotation;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _side2rotation;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _side3rotation;
public global::FrooxEngine.IField<UnityEngine.Quaternion> _topRotation;
public global::FrooxEngine.IField<UnityEngine.Vector3> _side0offset;
public global::FrooxEngine.IField<UnityEngine.Vector3> _side1offset;
public global::FrooxEngine.IField<UnityEngine.Vector3> _side2offset;
public global::FrooxEngine.IField<UnityEngine.Vector3> _side3offset;
public global::FrooxEngine.IField<UnityEngine.Vector3> _topOffset;
public global::FrooxEngine.IField<UnityEngine.Vector3> _side0contentOffset;
public global::FrooxEngine.IField<UnityEngine.Vector3> _side1contentOffset;
public global::FrooxEngine.IField<UnityEngine.Vector3> _side2contentOffset;
public global::FrooxEngine.IField<UnityEngine.Vector3> _side3contentOffset;
public global::FrooxEngine.IField<UnityEngine.Vector3> _topContentOffset;
public global::FrooxEngine.IField<UnityEngine.Vector3> _side0contentScale;
public global::FrooxEngine.IField<UnityEngine.Vector3> _side1contentScale;
public global::FrooxEngine.IField<UnityEngine.Vector3> _side2contentScale;
public global::FrooxEngine.IField<UnityEngine.Vector3> _side3contentScale;
public global::FrooxEngine.IField<UnityEngine.Vector3> _bottomContentScale;
public global::FrooxEngine.IField<UnityEngine.Vector3> _topContentScale;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Unwrap", Unwrap.ToResoniteLinkField());
members.Add("SideSize", SideSize.ToResoniteLinkField());
members.Add("ScaleContent", ScaleContent.ToResoniteLinkField());
members.Add("_side0rotation", _side0rotation.ToResoniteReference(context));
members.Add("_side1rotation", _side1rotation.ToResoniteReference(context));
members.Add("_side2rotation", _side2rotation.ToResoniteReference(context));
members.Add("_side3rotation", _side3rotation.ToResoniteReference(context));
members.Add("_topRotation", _topRotation.ToResoniteReference(context));
members.Add("_side0offset", _side0offset.ToResoniteReference(context));
members.Add("_side1offset", _side1offset.ToResoniteReference(context));
members.Add("_side2offset", _side2offset.ToResoniteReference(context));
members.Add("_side3offset", _side3offset.ToResoniteReference(context));
members.Add("_topOffset", _topOffset.ToResoniteReference(context));
members.Add("_side0contentOffset", _side0contentOffset.ToResoniteReference(context));
members.Add("_side1contentOffset", _side1contentOffset.ToResoniteReference(context));
members.Add("_side2contentOffset", _side2contentOffset.ToResoniteReference(context));
members.Add("_side3contentOffset", _side3contentOffset.ToResoniteReference(context));
members.Add("_topContentOffset", _topContentOffset.ToResoniteReference(context));
members.Add("_side0contentScale", _side0contentScale.ToResoniteReference(context));
members.Add("_side1contentScale", _side1contentScale.ToResoniteReference(context));
members.Add("_side2contentScale", _side2contentScale.ToResoniteReference(context));
members.Add("_side3contentScale", _side3contentScale.ToResoniteReference(context));
members.Add("_bottomContentScale", _bottomContentScale.ToResoniteReference(context));
members.Add("_topContentScale", _topContentScale.ToResoniteReference(context));
}

}
}

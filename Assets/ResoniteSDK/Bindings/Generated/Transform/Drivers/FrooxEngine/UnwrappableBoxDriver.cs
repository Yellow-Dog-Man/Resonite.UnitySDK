
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UnwrappableBoxDriver
// Generated on: pátek 13. února 2026 23:23:10
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Unwrap", Unwrap.ToResoniteLinkField());
members.Add("SideSize", SideSize.ToResoniteLinkField());
members.Add("ScaleContent", ScaleContent.ToResoniteLinkField());
members.Add("_side0rotation", new ResoniteLink.Reference() { });
members.Add("_side1rotation", new ResoniteLink.Reference() { });
members.Add("_side2rotation", new ResoniteLink.Reference() { });
members.Add("_side3rotation", new ResoniteLink.Reference() { });
members.Add("_topRotation", new ResoniteLink.Reference() { });
members.Add("_side0offset", new ResoniteLink.Reference() { });
members.Add("_side1offset", new ResoniteLink.Reference() { });
members.Add("_side2offset", new ResoniteLink.Reference() { });
members.Add("_side3offset", new ResoniteLink.Reference() { });
members.Add("_topOffset", new ResoniteLink.Reference() { });
members.Add("_side0contentOffset", new ResoniteLink.Reference() { });
members.Add("_side1contentOffset", new ResoniteLink.Reference() { });
members.Add("_side2contentOffset", new ResoniteLink.Reference() { });
members.Add("_side3contentOffset", new ResoniteLink.Reference() { });
members.Add("_topContentOffset", new ResoniteLink.Reference() { });
members.Add("_side0contentScale", new ResoniteLink.Reference() { });
members.Add("_side1contentScale", new ResoniteLink.Reference() { });
members.Add("_side2contentScale", new ResoniteLink.Reference() { });
members.Add("_side3contentScale", new ResoniteLink.Reference() { });
members.Add("_bottomContentScale", new ResoniteLink.Reference() { });
members.Add("_topContentScale", new ResoniteLink.Reference() { });
}

}
}

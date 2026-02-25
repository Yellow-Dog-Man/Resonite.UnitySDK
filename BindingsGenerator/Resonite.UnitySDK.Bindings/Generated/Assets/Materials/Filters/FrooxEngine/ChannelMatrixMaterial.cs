
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ChannelMatrixMaterial
// Generated on: středa 25. února 2026 16:13:03
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ChannelMatrixMaterial")]
public partial class ChannelMatrixMaterial : global::FrooxEngine.SingleShaderUI_StencilMaterial

{
    public global::System.Single RedFromRed;
public global::System.Single RedFromGreen;
public global::System.Single RedFromBlue;
public global::System.Single RedOffset;
public global::System.Single GreenFromRed;
public global::System.Single GreenFromGreen;
public global::System.Single GreenFromBlue;
public global::System.Single GreenOffset;
public global::System.Single BlueFromRed;
public global::System.Single BlueFromGreen;
public global::System.Single BlueFromBlue;
public global::System.Single BlueOffset;
public global::System.Single ClampRedMin;
public global::System.Single ClampGreenMin;
public global::System.Single ClampBlueMin;
public global::System.Single ClampRedMax;
public global::System.Single ClampGreenMax;
public global::System.Single ClampBlueMax;
public global::FrooxEngine.BlendMode BlendMode;
public global::FrooxEngine.Sidedness Sidedness;
public global::FrooxEngine.ZWrite ZWrite;
public global::FrooxEngine.ZTest ZTest;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RedFromRed", RedFromRed.ToResoniteLinkField());
members.Add("RedFromGreen", RedFromGreen.ToResoniteLinkField());
members.Add("RedFromBlue", RedFromBlue.ToResoniteLinkField());
members.Add("RedOffset", RedOffset.ToResoniteLinkField());
members.Add("GreenFromRed", GreenFromRed.ToResoniteLinkField());
members.Add("GreenFromGreen", GreenFromGreen.ToResoniteLinkField());
members.Add("GreenFromBlue", GreenFromBlue.ToResoniteLinkField());
members.Add("GreenOffset", GreenOffset.ToResoniteLinkField());
members.Add("BlueFromRed", BlueFromRed.ToResoniteLinkField());
members.Add("BlueFromGreen", BlueFromGreen.ToResoniteLinkField());
members.Add("BlueFromBlue", BlueFromBlue.ToResoniteLinkField());
members.Add("BlueOffset", BlueOffset.ToResoniteLinkField());
members.Add("ClampRedMin", ClampRedMin.ToResoniteLinkField());
members.Add("ClampGreenMin", ClampGreenMin.ToResoniteLinkField());
members.Add("ClampBlueMin", ClampBlueMin.ToResoniteLinkField());
members.Add("ClampRedMax", ClampRedMax.ToResoniteLinkField());
members.Add("ClampGreenMax", ClampGreenMax.ToResoniteLinkField());
members.Add("ClampBlueMax", ClampBlueMax.ToResoniteLinkField());
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
members.Add("Sidedness", Sidedness.ToResoniteLinkField());
members.Add("ZWrite", ZWrite.ToResoniteLinkField());
members.Add("ZTest", ZTest.ToResoniteLinkField());
}

}
}

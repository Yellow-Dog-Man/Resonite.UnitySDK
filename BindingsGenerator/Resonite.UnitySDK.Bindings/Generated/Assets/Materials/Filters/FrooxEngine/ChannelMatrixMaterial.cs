
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ChannelMatrixMaterial
// Generated on: čtvrtek 26. února 2026 15:07:53
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::System.Single RedFromRed { get => RedFromRed_Element.Data; set => RedFromRed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RedFromRed_Element = new();
public global::System.Single RedFromGreen { get => RedFromGreen_Element.Data; set => RedFromGreen_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RedFromGreen_Element = new();
public global::System.Single RedFromBlue { get => RedFromBlue_Element.Data; set => RedFromBlue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RedFromBlue_Element = new();
public global::System.Single RedOffset { get => RedOffset_Element.Data; set => RedOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> RedOffset_Element = new();
public global::System.Single GreenFromRed { get => GreenFromRed_Element.Data; set => GreenFromRed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GreenFromRed_Element = new();
public global::System.Single GreenFromGreen { get => GreenFromGreen_Element.Data; set => GreenFromGreen_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GreenFromGreen_Element = new();
public global::System.Single GreenFromBlue { get => GreenFromBlue_Element.Data; set => GreenFromBlue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GreenFromBlue_Element = new();
public global::System.Single GreenOffset { get => GreenOffset_Element.Data; set => GreenOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> GreenOffset_Element = new();
public global::System.Single BlueFromRed { get => BlueFromRed_Element.Data; set => BlueFromRed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BlueFromRed_Element = new();
public global::System.Single BlueFromGreen { get => BlueFromGreen_Element.Data; set => BlueFromGreen_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BlueFromGreen_Element = new();
public global::System.Single BlueFromBlue { get => BlueFromBlue_Element.Data; set => BlueFromBlue_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BlueFromBlue_Element = new();
public global::System.Single BlueOffset { get => BlueOffset_Element.Data; set => BlueOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BlueOffset_Element = new();
public global::System.Single ClampRedMin { get => ClampRedMin_Element.Data; set => ClampRedMin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ClampRedMin_Element = new();
public global::System.Single ClampGreenMin { get => ClampGreenMin_Element.Data; set => ClampGreenMin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ClampGreenMin_Element = new();
public global::System.Single ClampBlueMin { get => ClampBlueMin_Element.Data; set => ClampBlueMin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ClampBlueMin_Element = new();
public global::System.Single ClampRedMax { get => ClampRedMax_Element.Data; set => ClampRedMax_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ClampRedMax_Element = new();
public global::System.Single ClampGreenMax { get => ClampGreenMax_Element.Data; set => ClampGreenMax_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ClampGreenMax_Element = new();
public global::System.Single ClampBlueMax { get => ClampBlueMax_Element.Data; set => ClampBlueMax_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ClampBlueMax_Element = new();
public global::FrooxEngine.BlendMode BlendMode { get => BlendMode_Element.Data; set => BlendMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.BlendMode>, global::FrooxEngine.BlendMode> BlendMode_Element = new();
public global::FrooxEngine.Sidedness Sidedness { get => Sidedness_Element.Data; set => Sidedness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Sidedness>, global::FrooxEngine.Sidedness> Sidedness_Element = new();
public global::FrooxEngine.ZWrite ZWrite { get => ZWrite_Element.Data; set => ZWrite_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZWrite>, global::FrooxEngine.ZWrite> ZWrite_Element = new();
public global::FrooxEngine.ZTest ZTest { get => ZTest_Element.Data; set => ZTest_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ZTest>, global::FrooxEngine.ZTest> ZTest_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RedFromRed", RedFromRed_Element.ToLinkField(context));
members.Add("RedFromGreen", RedFromGreen_Element.ToLinkField(context));
members.Add("RedFromBlue", RedFromBlue_Element.ToLinkField(context));
members.Add("RedOffset", RedOffset_Element.ToLinkField(context));
members.Add("GreenFromRed", GreenFromRed_Element.ToLinkField(context));
members.Add("GreenFromGreen", GreenFromGreen_Element.ToLinkField(context));
members.Add("GreenFromBlue", GreenFromBlue_Element.ToLinkField(context));
members.Add("GreenOffset", GreenOffset_Element.ToLinkField(context));
members.Add("BlueFromRed", BlueFromRed_Element.ToLinkField(context));
members.Add("BlueFromGreen", BlueFromGreen_Element.ToLinkField(context));
members.Add("BlueFromBlue", BlueFromBlue_Element.ToLinkField(context));
members.Add("BlueOffset", BlueOffset_Element.ToLinkField(context));
members.Add("ClampRedMin", ClampRedMin_Element.ToLinkField(context));
members.Add("ClampGreenMin", ClampGreenMin_Element.ToLinkField(context));
members.Add("ClampBlueMin", ClampBlueMin_Element.ToLinkField(context));
members.Add("ClampRedMax", ClampRedMax_Element.ToLinkField(context));
members.Add("ClampGreenMax", ClampGreenMax_Element.ToLinkField(context));
members.Add("ClampBlueMax", ClampBlueMax_Element.ToLinkField(context));
members.Add("BlendMode", BlendMode_Element.ToLinkField(context));
members.Add("Sidedness", Sidedness_Element.ToLinkField(context));
members.Add("ZWrite", ZWrite_Element.ToLinkField(context));
members.Add("ZTest", ZTest_Element.ToLinkField(context));
}

}
}

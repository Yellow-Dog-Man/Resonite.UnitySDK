
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StringQRCodeTexture
// Generated on: čtvrtek 26. února 2026 15:07:56
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StringQRCodeTexture")]
public partial class StringQRCodeTexture : global::FrooxEngine.ProceduralTextureBase

{
    public global::Renderite.Shared.TextureFormat Format { get => Format_Element.Data; set => Format_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.TextureFormat>, global::Renderite.Shared.TextureFormat> Format_Element = new();
public global::System.String Payload { get => Payload_Element.Data; set => Payload_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Payload_Element = new();
public global::QRCoder.QRCodeGenerator.ECCLevel ECCLevel { get => ECCLevel_Element.Data; set => ECCLevel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::QRCoder.QRCodeGenerator.ECCLevel>, global::QRCoder.QRCodeGenerator.ECCLevel> ECCLevel_Element = new();
public UnityEngine.ColorX Color0 { get => Color0_Element.Data; set => Color0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color0_Element = new();
public UnityEngine.ColorX Color1 { get => Color1_Element.Data; set => Color1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color1_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Format", Format_Element.ToLinkField(context));
members.Add("Payload", Payload_Element.ToLinkField(context));
members.Add("ECCLevel", ECCLevel_Element.ToLinkField(context));
members.Add("Color0", Color0_Element.ToLinkField(context));
members.Add("Color1", Color1_Element.ToLinkField(context));
}

}
}

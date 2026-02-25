
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.StringQRCodeTexture
// Generated on: středa 25. února 2026 16:13:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.StringQRCodeTexture")]
public partial class StringQRCodeTexture : global::FrooxEngine.ProceduralTextureBase

{
    public global::Renderite.Shared.TextureFormat Format;
public global::System.String Payload;
public global::QRCoder.QRCodeGenerator.ECCLevel ECCLevel;
public UnityEngine.ColorX Color0;
public UnityEngine.ColorX Color1;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Format", Format.ToResoniteLinkField());
members.Add("Payload", Payload.ToResoniteLinkField());
members.Add("ECCLevel", ECCLevel.ToResoniteLinkField());
members.Add("Color0", Color0.ToResoniteLinkField());
members.Add("Color1", Color1.ToResoniteLinkField());
}

}
}

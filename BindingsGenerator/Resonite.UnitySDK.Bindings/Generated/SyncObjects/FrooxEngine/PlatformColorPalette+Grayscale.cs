
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PlatformColorPalette+Grayscale
// Generated on: čtvrtek 26. února 2026 15:09:17
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
    public partial class PlatformColorPalette
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PlatformColorPalette+Grayscale")]
public partial class Grayscale : global::FrooxEngine.SyncObject

{
    public global::System.String DarkHex { get => DarkHex_Element.Data; set => DarkHex_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> DarkHex_Element = new();
public global::System.String MidHex { get => MidHex_Element.Data; set => MidHex_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> MidHex_Element = new();
public global::System.String MidLightHex { get => MidLightHex_Element.Data; set => MidLightHex_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> MidLightHex_Element = new();
public global::System.String LightHex { get => LightHex_Element.Data; set => LightHex_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.String>, global::System.String> LightHex_Element = new();
public UnityEngine.ColorX Dark { get => Dark_Element.Data; set => Dark_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.ColorX>, UnityEngine.ColorX> Dark_Element = new();
public UnityEngine.ColorX Mid { get => Mid_Element.Data; set => Mid_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.ColorX>, UnityEngine.ColorX> Mid_Element = new();
public UnityEngine.ColorX MidLight { get => MidLight_Element.Data; set => MidLight_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.ColorX>, UnityEngine.ColorX> MidLight_Element = new();
public UnityEngine.ColorX Light { get => Light_Element.Data; set => Light_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<UnityEngine.ColorX>, UnityEngine.ColorX> Light_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DarkHex", DarkHex_Element.ToLinkField(context));
members.Add("MidHex", MidHex_Element.ToLinkField(context));
members.Add("MidLightHex", MidLightHex_Element.ToLinkField(context));
members.Add("LightHex", LightHex_Element.ToLinkField(context));
members.Add("Dark", Dark_Element.ToLinkField(context));
members.Add("Mid", Mid_Element.ToLinkField(context));
members.Add("MidLight", MidLight_Element.ToLinkField(context));
members.Add("Light", Light_Element.ToLinkField(context));
}

}
            }
}

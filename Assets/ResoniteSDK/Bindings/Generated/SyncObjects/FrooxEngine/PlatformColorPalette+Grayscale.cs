
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PlatformColorPalette+Grayscale
// Generated on: pátek 13. února 2026 5:52:40
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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
    public global::System.String DarkHex;
public global::System.String MidHex;
public global::System.String MidLightHex;
public global::System.String LightHex;
public UnityEngine.ColorX Dark;
public UnityEngine.ColorX Mid;
public UnityEngine.ColorX MidLight;
public UnityEngine.ColorX Light;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("DarkHex", DarkHex.ToResoniteLinkField());
members.Add("MidHex", MidHex.ToResoniteLinkField());
members.Add("MidLightHex", MidLightHex.ToResoniteLinkField());
members.Add("LightHex", LightHex.ToResoniteLinkField());
members.Add("Dark", Dark.ToResoniteLinkField());
members.Add("Mid", Mid.ToResoniteLinkField());
members.Add("MidLight", MidLight.ToResoniteLinkField());
members.Add("Light", Light.ToResoniteLinkField());
}

}
            }
}

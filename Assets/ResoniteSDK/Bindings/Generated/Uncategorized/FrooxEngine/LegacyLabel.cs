
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyLabel
// Generated on: pátek 13. února 2026 5:52:33
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyLabel")]
public partial class LegacyLabel : global::FrooxEngine.Component

{
    public global::FrooxEngine.TextRenderer TextRenderer;
public UnityEngine.ColorX BaseColor;
public global::FrooxEngine.ILegacyUIElement BaseColorElement;
public global::System.Single Brightness;
public global::System.Single LerpRatio;
public UnityEngine.ColorX LerpColor;
public global::FrooxEngine.IField<UnityEngine.ColorX> _textColor;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TextRenderer", new ResoniteLink.Reference() { });
members.Add("BaseColor", BaseColor.ToResoniteLinkField());
members.Add("BaseColorElement", new ResoniteLink.Reference() { });
members.Add("Brightness", Brightness.ToResoniteLinkField());
members.Add("LerpRatio", LerpRatio.ToResoniteLinkField());
members.Add("LerpColor", LerpColor.ToResoniteLinkField());
members.Add("_textColor", new ResoniteLink.Reference() { });
}

}
}

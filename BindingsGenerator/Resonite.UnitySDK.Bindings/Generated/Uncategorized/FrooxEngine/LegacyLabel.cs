
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyLabel
// Generated on: čtvrtek 26. února 2026 15:09:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyLabel")]
public partial class LegacyLabel : global::FrooxEngine.Component

{
    public global::FrooxEngine.TextRenderer TextRenderer { get => TextRenderer_Element.Data; set => TextRenderer_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> TextRenderer_Element = new();
public UnityEngine.ColorX BaseColor { get => BaseColor_Element.Data; set => BaseColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> BaseColor_Element = new();
public global::FrooxEngine.ILegacyUIElement BaseColorElement { get => BaseColorElement_Element.Data; set => BaseColorElement_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ILegacyUIElement>, global::FrooxEngine.ILegacyUIElement> BaseColorElement_Element = new();
public global::System.Single Brightness { get => Brightness_Element.Data; set => Brightness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Brightness_Element = new();
public global::System.Single LerpRatio { get => LerpRatio_Element.Data; set => LerpRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LerpRatio_Element = new();
public UnityEngine.ColorX LerpColor { get => LerpColor_Element.Data; set => LerpColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> LerpColor_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _textColor { get => _textColor_Element.Data; set => _textColor_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _textColor_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TextRenderer", TextRenderer_Element.ToLinkReference(context));
members.Add("BaseColor", BaseColor_Element.ToLinkField(context));
members.Add("BaseColorElement", BaseColorElement_Element.ToLinkReference(context));
members.Add("Brightness", Brightness_Element.ToLinkField(context));
members.Add("LerpRatio", LerpRatio_Element.ToLinkField(context));
members.Add("LerpColor", LerpColor_Element.ToLinkField(context));
members.Add("_textColor", _textColor_Element.ToLinkReference(context));
}

}
}

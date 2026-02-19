
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AppEnder
// Generated on: čtvrtek 19. února 2026 8:00:26
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AppEnder")]
public partial class AppEnder : global::FrooxEngine.Component

{
    public global::FrooxEngine.AppEnder.EndMode Mode;
public global::System.Boolean ChangesSaved;
public global::FrooxEngine.TextRenderer _text;
public global::FrooxEngine.IField<UnityEngine.ColorX> _textColor;
public global::FrooxEngine.IField<UnityEngine.ColorX> _outlineColor;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mode", Mode.ToResoniteLinkField());
members.Add("ChangesSaved", ChangesSaved.ToResoniteLinkField());
members.Add("_text", _text.ToResoniteReference(context));
members.Add("_textColor", _textColor.ToResoniteReference(context));
members.Add("_outlineColor", _outlineColor.ToResoniteReference(context));
}

}
}

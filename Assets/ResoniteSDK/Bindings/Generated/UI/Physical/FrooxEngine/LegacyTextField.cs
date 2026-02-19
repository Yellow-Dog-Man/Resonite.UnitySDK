
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyTextField
// Generated on: čtvrtek 19. února 2026 8:00:25
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyTextField")]
public partial class LegacyTextField : global::FrooxEngine.LegacyFieldBase, global::FrooxEngine.ITextField

{
    public global::System.Boolean IsEnabled;
public global::FrooxEngine.TextRenderer _hintTextRenderer;
public global::FrooxEngine.IField<UnityEngine.Vector2> _hintTextBounds;
public global::FrooxEngine.IField<global::System.Boolean> _hintTextEnabled;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsEnabled", IsEnabled.ToResoniteLinkField());
members.Add("_hintTextRenderer", _hintTextRenderer.ToResoniteReference(context));
members.Add("_hintTextBounds", _hintTextBounds.ToResoniteReference(context));
members.Add("_hintTextEnabled", _hintTextEnabled.ToResoniteReference(context));
}

}
}

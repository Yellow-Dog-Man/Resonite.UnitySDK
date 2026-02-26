
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyTextField
// Generated on: čtvrtek 26. února 2026 10:04:42
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyTextField")]
public partial class LegacyTextField : global::FrooxEngine.LegacyFieldBase, global::FrooxEngine.ITextField

{
    public global::System.Boolean IsEnabled { get => IsEnabled_Element.Data; set => IsEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsEnabled_Element = new();
public global::FrooxEngine.TextRenderer _hintTextRenderer { get => _hintTextRenderer_Element.Data; set => _hintTextRenderer_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> _hintTextRenderer_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector2> _hintTextBounds { get => _hintTextBounds_Element.Data; set => _hintTextBounds_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector2>, global::FrooxEngine.IField<UnityEngine.Vector2>> _hintTextBounds_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _hintTextEnabled { get => _hintTextEnabled_Element.Data; set => _hintTextEnabled_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _hintTextEnabled_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsEnabled", IsEnabled_Element.Data.ToResoniteLinkField());
members.Add("_hintTextRenderer", _hintTextRenderer_Element.Data.ToResoniteReference(context));
members.Add("_hintTextBounds", _hintTextBounds_Element.Data.ToResoniteReference(context));
members.Add("_hintTextEnabled", _hintTextEnabled_Element.Data.ToResoniteReference(context));
}

}
}

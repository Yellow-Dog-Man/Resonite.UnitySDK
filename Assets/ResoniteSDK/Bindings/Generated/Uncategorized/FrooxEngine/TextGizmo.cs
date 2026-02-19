
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextGizmo
// Generated on: čtvrtek 19. února 2026 8:00:31
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextGizmo")]
public partial class TextGizmo : global::FrooxEngine.Component, global::FrooxEngine.IComponentGizmo

{
    public global::FrooxEngine.TextRenderer _target;
public global::FrooxEngine.TextEditor _editor;
public global::FrooxEngine.IField<UnityEngine.Vector3> _editIconPosition;
public global::FrooxEngine.IField<UnityEngine.Vector3> _editIconScale;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_target", _target.ToResoniteReference(context));
members.Add("_editor", _editor.ToResoniteReference(context));
members.Add("_editIconPosition", _editIconPosition.ToResoniteReference(context));
members.Add("_editIconScale", _editIconScale.ToResoniteReference(context));
}

}
}

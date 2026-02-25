
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FieldEditor
// Generated on: středa 25. února 2026 16:14:38
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FieldEditor")]
public partial class FieldEditor : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField _targetField;
public System.Collections.Generic.List<global::FrooxEngine.TextEditor> _textEditors;
public System.Collections.Generic.List<global::FrooxEngine.IField<global::System.String>> _textDrives;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_targetField", _targetField.ToResoniteReference(context));
members.Add("_textEditors", new ResoniteLink.SyncList()
{
    Elements = _textEditors.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("_textDrives", new ResoniteLink.SyncList()
{
    Elements = _textDrives.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}

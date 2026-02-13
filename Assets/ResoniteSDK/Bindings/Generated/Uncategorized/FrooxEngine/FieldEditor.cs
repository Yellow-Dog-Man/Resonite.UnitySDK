
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FieldEditor
// Generated on: pátek 13. února 2026 23:23:13
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FieldEditor")]
public partial class FieldEditor : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField _targetField;
public System.Collections.Generic.List<global::FrooxEngine.TextEditor> _textEditors;
public System.Collections.Generic.List<global::FrooxEngine.IField<global::System.String>> _textDrives;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_targetField", new ResoniteLink.Reference() { });
members.Add("_textEditors", new ResoniteLink.SyncList()
{
    Elements = _textEditors.ConvertList(m => new ResoniteLink.Reference() { })
});
members.Add("_textDrives", new ResoniteLink.SyncList()
{
    Elements = _textDrives.ConvertList(m => new ResoniteLink.Reference() { })
});
}

}
}

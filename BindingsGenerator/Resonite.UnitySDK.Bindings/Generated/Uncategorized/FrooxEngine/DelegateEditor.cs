
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DelegateEditor
// Generated on: čtvrtek 26. února 2026 12:28:10
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DelegateEditor")]
public partial class DelegateEditor : global::FrooxEngine.Component, global::FrooxEngine.UIX.IUIGrabReceiver, global::FrooxEngine.UIX.IUIGrabbable

{
    public global::FrooxEngine.ISyncDelegate _targetDelegate { get => _targetDelegate_Element.Data; set => _targetDelegate_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.ISyncDelegate>, global::FrooxEngine.ISyncDelegate> _targetDelegate_Element = new();
public global::FrooxEngine.IField<global::System.String> _textDrive { get => _textDrive_Element.Data; set => _textDrive_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> _textDrive_Element = new();
public global::FrooxEngine.UIX.Button _button { get => _button_Element.Data; set => _button_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _button_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_targetDelegate", _targetDelegate_Element.ToLinkReference(context));
members.Add("_textDrive", _textDrive_Element.ToLinkReference(context));
members.Add("_button", _button_Element.ToLinkReference(context));
}

}
}

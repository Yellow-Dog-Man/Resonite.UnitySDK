
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DelegateEditor
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DelegateEditor")]
public partial class DelegateEditor : global::FrooxEngine.Component, global::FrooxEngine.UIX.IUIGrabReceiver, global::FrooxEngine.UIX.IUIGrabbable

{
    public global::FrooxEngine.ISyncDelegate _targetDelegate;
public global::FrooxEngine.IField<global::System.String> _textDrive;
public global::FrooxEngine.UIX.Button _button;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_targetDelegate", _targetDelegate.ToResoniteReference(context));
members.Add("_textDrive", _textDrive.ToResoniteReference(context));
members.Add("_button", _button.ToResoniteReference(context));
}

}
}

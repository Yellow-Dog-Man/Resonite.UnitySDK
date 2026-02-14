
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RefEditor
// Generated on: sobota 14. února 2026 8:58:47
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RefEditor")]
public partial class RefEditor : global::FrooxEngine.Component, global::FrooxEngine.UIX.IUIGrabReceiver, global::FrooxEngine.UIX.IUIGrabbable

{
    public global::FrooxEngine.ISyncRef _targetRef;
public global::FrooxEngine.IField<global::System.String> _textDrive;
public global::FrooxEngine.UIX.Button _button;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_targetRef", _targetRef.ToResoniteReference(context));
members.Add("_textDrive", _textDrive.ToResoniteReference(context));
members.Add("_button", _button.ToResoniteReference(context));
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.TextField
// Generated on: středa 25. února 2026 16:14:15
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.TextField")]
public partial class TextField : global::FrooxEngine.UIX.UIComponent, global::FrooxEngine.IButtonPressReceiver, global::FrooxEngine.UIX.IUIGrabbable, global::FrooxEngine.UIX.IUIGrabReceiver

{
    public global::FrooxEngine.TextEditor Editor;
public global::FrooxEngine.UIX.Text __text;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Editor", Editor.ToResoniteReference(context));
members.Add("__text", __text.ToResoniteReference(context));
}

}
}

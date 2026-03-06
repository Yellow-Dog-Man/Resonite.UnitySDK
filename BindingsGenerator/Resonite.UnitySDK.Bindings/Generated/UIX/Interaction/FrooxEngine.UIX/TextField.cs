
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.TextField
// Generated on: pátek 6. března 2026 14:19:02
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public global::FrooxEngine.TextEditor Editor { get => Editor_Element.Data; set => Editor_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TextEditor>, global::FrooxEngine.TextEditor> Editor_Element = new();
public global::FrooxEngine.UIX.Text __text { get => __text_Element.Data; set => __text_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> __text_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Editor", Editor_Element.ToLinkReference(context));
members.Add("__text", __text_Element.ToLinkReference(context));
}

}
}

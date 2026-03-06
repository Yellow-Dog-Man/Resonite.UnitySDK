
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.EngineDebugDialog
// Generated on: pátek 6. března 2026 14:19:08
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.EngineDebugDialog")]
public partial class EngineDebugDialog : global::FrooxEngine.Component

{
    public global::FrooxEngine.EngineDebugDialog.Mode DisplayMode { get => DisplayMode_Element.Data; set => DisplayMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.EngineDebugDialog.Mode>, global::FrooxEngine.EngineDebugDialog.Mode> DisplayMode_Element = new();
public global::FrooxEngine.Slot _contentRoot { get => _contentRoot_Element.Data; set => _contentRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _contentRoot_Element = new();
public global::FrooxEngine.UIX.Text _text { get => _text_Element.Data; set => _text_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _text_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DisplayMode", DisplayMode_Element.ToLinkField(context));
members.Add("_contentRoot", _contentRoot_Element.ToLinkReference(context));
members.Add("_text", _text_Element.ToLinkReference(context));
}

}
}

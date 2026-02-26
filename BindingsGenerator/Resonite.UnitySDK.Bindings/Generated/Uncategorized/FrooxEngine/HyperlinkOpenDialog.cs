
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HyperlinkOpenDialog
// Generated on: čtvrtek 26. února 2026 10:04:45
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HyperlinkOpenDialog")]
public partial class HyperlinkOpenDialog : global::FrooxEngine.Component

{
    public System.Uri URL { get => URL_Element.Data; set => URL_Element.Data = value; }
public Field<global::FrooxEngine.Sync<System.Uri>, System.Uri> URL_Element = new();
public global::FrooxEngine.UIX.Text _hyperlinkText { get => _hyperlinkText_Element.Data; set => _hyperlinkText_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _hyperlinkText_Element = new();
public global::FrooxEngine.UIX.Text _reasonText { get => _reasonText_Element.Data; set => _reasonText_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _reasonText_Element = new();
public global::FrooxEngine.UIX.Button _openButton { get => _openButton_Element.Data; set => _openButton_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _openButton_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("URL", URL_Element.Data.ToResoniteLinkField());
members.Add("_hyperlinkText", _hyperlinkText_Element.Data.ToResoniteReference(context));
members.Add("_reasonText", _reasonText_Element.Data.ToResoniteReference(context));
members.Add("_openButton", _openButton_Element.Data.ToResoniteReference(context));
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BrowserCreateDirectoryDialog
// Generated on: čtvrtek 26. února 2026 12:28:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BrowserCreateDirectoryDialog")]
public partial class BrowserCreateDirectoryDialog : global::FrooxEngine.Component

{
    public global::FrooxEngine.BrowserDialog _browser { get => _browser_Element.Data; set => _browser_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.BrowserDialog>, global::FrooxEngine.BrowserDialog> _browser_Element = new();
public global::FrooxEngine.UIX.Text _text { get => _text_Element.Data; set => _text_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _text_Element = new();
public global::FrooxEngine.UIX.TextField _textField { get => _textField_Element.Data; set => _textField_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _textField_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_browser", _browser_Element.ToLinkReference(context));
members.Add("_text", _text_Element.ToLinkReference(context));
members.Add("_textField", _textField_Element.ToLinkReference(context));
}

}
}

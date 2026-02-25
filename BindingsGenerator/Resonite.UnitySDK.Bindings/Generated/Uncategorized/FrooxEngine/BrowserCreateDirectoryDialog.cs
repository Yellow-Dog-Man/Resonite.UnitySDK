
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BrowserCreateDirectoryDialog
// Generated on: středa 25. února 2026 16:14:35
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BrowserCreateDirectoryDialog")]
public partial class BrowserCreateDirectoryDialog : global::FrooxEngine.Component

{
    public global::FrooxEngine.BrowserDialog _browser;
public global::FrooxEngine.UIX.Text _text;
public global::FrooxEngine.UIX.TextField _textField;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_browser", _browser.ToResoniteReference(context));
members.Add("_text", _text.ToResoniteReference(context));
members.Add("_textField", _textField.ToResoniteReference(context));
}

}
}

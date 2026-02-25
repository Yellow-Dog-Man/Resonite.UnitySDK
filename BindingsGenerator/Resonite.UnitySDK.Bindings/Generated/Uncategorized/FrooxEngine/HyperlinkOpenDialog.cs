
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HyperlinkOpenDialog
// Generated on: středa 25. února 2026 16:14:39
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
    public System.Uri URL;
public global::FrooxEngine.UIX.Text _hyperlinkText;
public global::FrooxEngine.UIX.Text _reasonText;
public global::FrooxEngine.UIX.Button _openButton;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("URL", URL.ToResoniteLinkField());
members.Add("_hyperlinkText", _hyperlinkText.ToResoniteReference(context));
members.Add("_reasonText", _reasonText.ToResoniteReference(context));
members.Add("_openButton", _openButton.ToResoniteReference(context));
}

}
}

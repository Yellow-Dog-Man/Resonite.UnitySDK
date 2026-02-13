
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HyperlinkOpenDialog
// Generated on: pátek 13. února 2026 23:23:15
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HyperlinkOpenDialog")]
public partial class HyperlinkOpenDialog : global::FrooxEngine.Component

{
    public System.Uri URL;
public global::FrooxEngine.UIX.Text _hyperlinkText;
public global::FrooxEngine.UIX.Text _reasonText;
public global::FrooxEngine.UIX.Button _openButton;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("URL", URL.ToResoniteLinkField());
members.Add("_hyperlinkText", new ResoniteLink.Reference() { });
members.Add("_reasonText", new ResoniteLink.Reference() { });
members.Add("_openButton", new ResoniteLink.Reference() { });
}

}
}

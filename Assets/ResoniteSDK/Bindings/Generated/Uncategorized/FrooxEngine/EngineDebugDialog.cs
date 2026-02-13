
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.EngineDebugDialog
// Generated on: pátek 13. února 2026 5:52:30
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.EngineDebugDialog")]
public partial class EngineDebugDialog : global::FrooxEngine.Component

{
    public global::FrooxEngine.EngineDebugDialog.Mode DisplayMode;
public global::FrooxEngine.Slot _contentRoot;
public global::FrooxEngine.UIX.Text _text;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("DisplayMode", DisplayMode.ToResoniteLinkField());
members.Add("_contentRoot", new ResoniteLink.Reference() { });
members.Add("_text", new ResoniteLink.Reference() { });
}

}
}

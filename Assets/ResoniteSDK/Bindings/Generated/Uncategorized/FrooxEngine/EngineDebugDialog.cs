
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.EngineDebugDialog
// Generated on: úterý 24. února 2026 18:20:20
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DisplayMode", DisplayMode.ToResoniteLinkField());
members.Add("_contentRoot", _contentRoot.ToResoniteReference(context));
members.Add("_text", _text.ToResoniteReference(context));
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VirtualKey
// Generated on: pátek 13. února 2026 5:52:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VirtualKey")]
public partial class VirtualKey : global::FrooxEngine.VirtualKeyBase, global::FrooxEngine.IButtonPressReceiver

{
    public global::Renderite.Shared.Key TargetKey;
public global::System.String AppendString;
public global::Renderite.Shared.Key ShiftTargetKey;
public global::System.String ShiftAppendString;
public global::System.Boolean IgnoreShift;
public global::FrooxEngine.VirtualModifierKey ModifierKey;
public global::Renderite.Shared.Key ModifiedTargetKey;
public global::System.String ModifiedAppendString;
public global::FrooxEngine.VirtualKeyboard Keyboard;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetKey", TargetKey.ToResoniteLinkField());
members.Add("AppendString", AppendString.ToResoniteLinkField());
members.Add("ShiftTargetKey", ShiftTargetKey.ToResoniteLinkField());
members.Add("ShiftAppendString", ShiftAppendString.ToResoniteLinkField());
members.Add("IgnoreShift", IgnoreShift.ToResoniteLinkField());
members.Add("ModifierKey", new ResoniteLink.Reference() { });
members.Add("ModifiedTargetKey", ModifiedTargetKey.ToResoniteLinkField());
members.Add("ModifiedAppendString", ModifiedAppendString.ToResoniteLinkField());
members.Add("Keyboard", new ResoniteLink.Reference() { });
}

}
}

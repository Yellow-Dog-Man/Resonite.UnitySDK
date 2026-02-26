
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VirtualCloseKey
// Generated on: čtvrtek 26. února 2026 15:09:17
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VirtualCloseKey")]
public partial class VirtualCloseKey : global::FrooxEngine.VirtualKeyBase, global::FrooxEngine.IButtonPressReceiver

{
    public global::FrooxEngine.VirtualKeyboard Keyboard { get => Keyboard_Element.Data; set => Keyboard_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.VirtualKeyboard>, global::FrooxEngine.VirtualKeyboard> Keyboard_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Keyboard", Keyboard_Element.ToLinkReference(context));
}

}
}

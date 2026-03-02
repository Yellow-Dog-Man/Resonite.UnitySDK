
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonWorldLink
// Generated on: pondělí 2. března 2026 17:52:28
// Resonite version: 2026.3.2.1000
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonWorldLink")]
public partial class ButtonWorldLink : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::FrooxEngine.WorldLink WorldLink { get => WorldLink_Element.Data; set => WorldLink_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.WorldLink>, global::FrooxEngine.WorldLink> WorldLink_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("WorldLink", WorldLink_Element.ToLinkReference(context));
}

}
}

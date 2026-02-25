
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.InteractionBlock
// Generated on: středa 25. února 2026 16:14:33
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.InteractionBlock")]
public partial class InteractionBlock : global::FrooxEngine.Component, global::FrooxEngine.UIX.IUIInteractable

{
    public global::System.Boolean TouchExitLock;
public global::System.Boolean TouchEnterLock;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TouchExitLock", TouchExitLock.ToResoniteLinkField());
members.Add("TouchEnterLock", TouchEnterLock.ToResoniteLinkField());
}

}
}

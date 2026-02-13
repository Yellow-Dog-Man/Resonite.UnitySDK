
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.InteractionBlock
// Generated on: pátek 13. února 2026 23:23:11
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TouchExitLock", TouchExitLock.ToResoniteLinkField());
members.Add("TouchEnterLock", TouchEnterLock.ToResoniteLinkField());
}

}
}

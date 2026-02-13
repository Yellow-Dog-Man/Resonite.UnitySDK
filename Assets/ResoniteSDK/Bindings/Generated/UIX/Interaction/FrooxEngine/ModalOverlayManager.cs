
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ModalOverlayManager
// Generated on: pátek 13. února 2026 5:52:28
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ModalOverlayManager")]
public partial class ModalOverlayManager : global::FrooxEngine.Component

{
    public global::FrooxEngine.UIX.ModalOverlay Template;
public global::FrooxEngine.Slot SpawnRoot;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Template", new ResoniteLink.Reference() { });
members.Add("SpawnRoot", new ResoniteLink.Reference() { });
}

}
}

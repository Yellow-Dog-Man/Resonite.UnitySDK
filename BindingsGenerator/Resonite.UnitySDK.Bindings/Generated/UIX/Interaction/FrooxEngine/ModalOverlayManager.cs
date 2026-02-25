
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ModalOverlayManager
// Generated on: středa 25. února 2026 16:14:33
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ModalOverlayManager")]
public partial class ModalOverlayManager : global::FrooxEngine.Component

{
    public global::FrooxEngine.UIX.ModalOverlay Template;
public global::FrooxEngine.Slot SpawnRoot;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Template", Template.ToResoniteReference(context));
members.Add("SpawnRoot", SpawnRoot.ToResoniteReference(context));
}

}
}

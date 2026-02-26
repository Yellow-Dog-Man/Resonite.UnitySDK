
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ModalOverlayManager
// Generated on: čtvrtek 26. února 2026 12:28:08
// Resonite version: 2026.2.26.702
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
    public global::FrooxEngine.UIX.ModalOverlay Template { get => Template_Element.Data; set => Template_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.ModalOverlay>, global::FrooxEngine.UIX.ModalOverlay> Template_Element = new();
public global::FrooxEngine.Slot SpawnRoot { get => SpawnRoot_Element.Data; set => SpawnRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> SpawnRoot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Template", Template_Element.ToLinkReference(context));
members.Add("SpawnRoot", SpawnRoot_Element.ToLinkReference(context));
}

}
}

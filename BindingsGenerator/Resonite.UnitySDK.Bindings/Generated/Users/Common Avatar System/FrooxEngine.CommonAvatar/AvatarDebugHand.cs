
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarDebugHand
// Generated on: čtvrtek 26. února 2026 15:09:16
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarDebugHand")]
public partial class AvatarDebugHand : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.Slot>, global::FrooxEngine.Slot, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot>> _objects = new();
public global::FrooxEngine.HierarchyMaterialTarget _materialTarget { get => _materialTarget_Element.Data; set => _materialTarget_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.HierarchyMaterialTarget>, global::FrooxEngine.HierarchyMaterialTarget> _materialTarget_Element = new();
public global::FrooxEngine.PBS_Metallic _material { get => _material_Element.Data; set => _material_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.PBS_Metallic>, global::FrooxEngine.PBS_Metallic> _material_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_objects", _objects.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("_materialTarget", _materialTarget_Element.ToLinkReference(context));
members.Add("_material", _material_Element.ToLinkReference(context));
}

}
}

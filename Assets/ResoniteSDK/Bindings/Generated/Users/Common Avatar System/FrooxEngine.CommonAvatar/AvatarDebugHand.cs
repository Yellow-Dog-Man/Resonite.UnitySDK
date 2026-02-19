
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarDebugHand
// Generated on: čtvrtek 19. února 2026 8:00:32
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public System.Collections.Generic.List<global::FrooxEngine.Slot> _objects;
public global::FrooxEngine.HierarchyMaterialTarget _materialTarget;
public global::FrooxEngine.PBS_Metallic _material;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_objects", new ResoniteLink.SyncList()
{
    Elements = _objects.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("_materialTarget", _materialTarget.ToResoniteReference(context));
members.Add("_material", _material.ToResoniteReference(context));
}

}
}

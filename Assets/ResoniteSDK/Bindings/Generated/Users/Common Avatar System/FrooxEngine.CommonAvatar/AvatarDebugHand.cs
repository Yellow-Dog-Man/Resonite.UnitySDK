
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarDebugHand
// Generated on: pátek 13. února 2026 23:23:19
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_objects", new ResoniteLink.SyncList()
{
    Elements = _objects.ConvertList(m => new ResoniteLink.Reference() { })
});
members.Add("_materialTarget", new ResoniteLink.Reference() { });
members.Add("_material", new ResoniteLink.Reference() { });
}

}
}

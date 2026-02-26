
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarManager+EquippedGroup
// Generated on: čtvrtek 26. února 2026 12:28:15
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    public partial class AvatarManager
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarManager+EquippedGroup")]
public partial class EquippedGroup : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.CommonAvatar.AvatarGroup Group { get => Group_Element.Data; set => Group_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.AvatarGroup>, global::FrooxEngine.CommonAvatar.AvatarGroup> Group_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.CommonAvatar.IAvatarObject>, global::FrooxEngine.CommonAvatar.IAvatarObject, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.IAvatarObject>, global::FrooxEngine.CommonAvatar.IAvatarObject>> Objects = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Group", Group_Element.ToLinkReference(context));
members.Add("Objects", Objects.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
            }
}

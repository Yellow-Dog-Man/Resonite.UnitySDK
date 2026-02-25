
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarManager+EquippedGroup
// Generated on: středa 25. února 2026 16:14:45
// Resonite version: 2026.2.25.455
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
    public global::FrooxEngine.CommonAvatar.AvatarGroup Group;
public System.Collections.Generic.List<global::FrooxEngine.CommonAvatar.IAvatarObject> Objects;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Group", Group.ToResoniteReference(context));
members.Add("Objects", new ResoniteLink.SyncList()
{
    Elements = Objects.ConvertList(m => m.ToResoniteReference(context))
});
}

}
            }
}

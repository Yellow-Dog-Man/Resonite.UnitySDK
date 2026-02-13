
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarManager+EquippedGroup
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
    public partial class AvatarManager
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarManager+EquippedGroup")]
public partial class EquippedGroup : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.CommonAvatar.AvatarGroup Group;
public System.Collections.Generic.List<global::FrooxEngine.CommonAvatar.IAvatarObject> Objects;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Group", new ResoniteLink.Reference() { });
members.Add("Objects", new ResoniteLink.SyncList()
{
    Elements = Objects.ConvertList(m => new ResoniteLink.Reference() { })
});
}

}
            }
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarBadgeManager
// Generated on: pátek 13. února 2026 23:23:20
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarBadgeManager")]
public partial class AvatarBadgeManager : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::System.Single BadgeSize;
public global::System.Single BadgeSeparation;
public global::System.Int32 MaxRowSize;
public global::FrooxEngine.Slot _badgesRoot;
public global::FrooxEngine.IField<UnityEngine.Vector3> _badgesOffset;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("BadgeSize", BadgeSize.ToResoniteLinkField());
members.Add("BadgeSeparation", BadgeSeparation.ToResoniteLinkField());
members.Add("MaxRowSize", MaxRowSize.ToResoniteLinkField());
members.Add("_badgesRoot", new ResoniteLink.Reference() { });
members.Add("_badgesOffset", new ResoniteLink.Reference() { });
}

}
}

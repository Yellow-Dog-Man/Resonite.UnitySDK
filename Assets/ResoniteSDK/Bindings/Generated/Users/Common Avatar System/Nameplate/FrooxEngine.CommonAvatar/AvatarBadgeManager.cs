
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarBadgeManager
// Generated on: úterý 24. února 2026 18:20:32
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BadgeSize", BadgeSize.ToResoniteLinkField());
members.Add("BadgeSeparation", BadgeSeparation.ToResoniteLinkField());
members.Add("MaxRowSize", MaxRowSize.ToResoniteLinkField());
members.Add("_badgesRoot", _badgesRoot.ToResoniteReference(context));
members.Add("_badgesOffset", _badgesOffset.ToResoniteReference(context));
}

}
}

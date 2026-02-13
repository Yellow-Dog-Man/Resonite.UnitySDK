
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarRoot
// Generated on: pátek 13. února 2026 5:52:38
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarRoot")]
public partial class AvatarRoot : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObject, global::FrooxEngine.ITouchable

{
    public UnityEngine.Vector3 Scale;
public global::FrooxEngine.Slot _originalParent;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Scale", Scale.ToResoniteLinkField());
members.Add("_originalParent", new ResoniteLink.Reference() { });
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarUserViewHeadOverride
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarUserViewHeadOverride")]
public partial class AvatarUserViewHeadOverride : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::FrooxEngine.RenderTransformOverride RenderTransformOverride;
public global::FrooxEngine.IField<global::System.Boolean> _overrideEnabled;
public global::FrooxEngine.IField<global::System.Nullable<UnityEngine.Vector3>> _posOverride;
public global::FrooxEngine.IField<global::System.Nullable<UnityEngine.Quaternion>> _rotOverride;
public global::FrooxEngine.CommonAvatar.AvatarObjectSlot _equippingSlot;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("RenderTransformOverride", new ResoniteLink.Reference() { });
members.Add("_overrideEnabled", new ResoniteLink.Reference() { });
members.Add("_posOverride", new ResoniteLink.Reference() { });
members.Add("_rotOverride", new ResoniteLink.Reference() { });
members.Add("_equippingSlot", new ResoniteLink.Reference() { });
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarUserViewHeadOverride
// Generated on: sobota 14. února 2026 8:58:49
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RenderTransformOverride", RenderTransformOverride.ToResoniteReference(context));
members.Add("_overrideEnabled", _overrideEnabled.ToResoniteReference(context));
members.Add("_posOverride", _posOverride.ToResoniteReference(context));
members.Add("_rotOverride", _rotOverride.ToResoniteReference(context));
members.Add("_equippingSlot", _equippingSlot.ToResoniteReference(context));
}

}
}

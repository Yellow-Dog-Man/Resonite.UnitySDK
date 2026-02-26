
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarUserViewHeadOverride
// Generated on: čtvrtek 26. února 2026 15:09:16
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.RenderTransformOverride RenderTransformOverride { get => RenderTransformOverride_Element.Data; set => RenderTransformOverride_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.RenderTransformOverride>, global::FrooxEngine.RenderTransformOverride> RenderTransformOverride_Element = new();
public global::FrooxEngine.IField<global::System.Boolean> _overrideEnabled { get => _overrideEnabled_Element.Data; set => _overrideEnabled_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Boolean>, global::FrooxEngine.IField<global::System.Boolean>> _overrideEnabled_Element = new();
public global::FrooxEngine.IField<global::System.Nullable<UnityEngine.Vector3>> _posOverride { get => _posOverride_Element.Data; set => _posOverride_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Nullable<UnityEngine.Vector3>>, global::FrooxEngine.IField<global::System.Nullable<UnityEngine.Vector3>>> _posOverride_Element = new();
public global::FrooxEngine.IField<global::System.Nullable<UnityEngine.Quaternion>> _rotOverride { get => _rotOverride_Element.Data; set => _rotOverride_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Nullable<UnityEngine.Quaternion>>, global::FrooxEngine.IField<global::System.Nullable<UnityEngine.Quaternion>>> _rotOverride_Element = new();
public global::FrooxEngine.CommonAvatar.AvatarObjectSlot _equippingSlot { get => _equippingSlot_Element.Data; set => _equippingSlot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.CommonAvatar.AvatarObjectSlot>, global::FrooxEngine.CommonAvatar.AvatarObjectSlot> _equippingSlot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RenderTransformOverride", RenderTransformOverride_Element.ToLinkReference(context));
members.Add("_overrideEnabled", _overrideEnabled_Element.ToLinkReference(context));
members.Add("_posOverride", _posOverride_Element.ToLinkReference(context));
members.Add("_rotOverride", _rotOverride_Element.ToLinkReference(context));
members.Add("_equippingSlot", _equippingSlot_Element.ToLinkReference(context));
}

}
}

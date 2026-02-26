
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarBadgeManager
// Generated on: čtvrtek 26. února 2026 10:04:50
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarBadgeManager")]
public partial class AvatarBadgeManager : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::System.Single BadgeSize { get => BadgeSize_Element.Data; set => BadgeSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BadgeSize_Element = new();
public global::System.Single BadgeSeparation { get => BadgeSeparation_Element.Data; set => BadgeSeparation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BadgeSeparation_Element = new();
public global::System.Int32 MaxRowSize { get => MaxRowSize_Element.Data; set => MaxRowSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> MaxRowSize_Element = new();
public global::FrooxEngine.Slot _badgesRoot { get => _badgesRoot_Element.Data; set => _badgesRoot_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _badgesRoot_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> _badgesOffset { get => _badgesOffset_Element.Data; set => _badgesOffset_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> _badgesOffset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BadgeSize", BadgeSize_Element.Data.ToResoniteLinkField());
members.Add("BadgeSeparation", BadgeSeparation_Element.Data.ToResoniteLinkField());
members.Add("MaxRowSize", MaxRowSize_Element.Data.ToResoniteLinkField());
members.Add("_badgesRoot", _badgesRoot_Element.Data.ToResoniteReference(context));
members.Add("_badgesOffset", _badgesOffset_Element.Data.ToResoniteReference(context));
}

}
}

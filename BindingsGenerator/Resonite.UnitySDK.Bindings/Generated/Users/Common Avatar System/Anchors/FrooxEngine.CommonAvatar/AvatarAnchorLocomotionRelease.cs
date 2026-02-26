
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarAnchorLocomotionRelease
// Generated on: čtvrtek 26. února 2026 10:04:49
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarAnchorLocomotionRelease")]
public partial class AvatarAnchorLocomotionRelease : global::FrooxEngine.Component, global::FrooxEngine.IInputUpdateReceiver

{
    public global::System.Boolean ReleaseOnBinaryAction { get => ReleaseOnBinaryAction_Element.Data; set => ReleaseOnBinaryAction_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ReleaseOnBinaryAction_Element = new();
public global::System.Nullable<global::System.Single> ReleaseStrengthThreshold { get => ReleaseStrengthThreshold_Element.Data; set => ReleaseStrengthThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> ReleaseStrengthThreshold_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ReleaseOnBinaryAction", ReleaseOnBinaryAction_Element.Data.ToResoniteLinkField());
members.Add("ReleaseStrengthThreshold", ReleaseStrengthThreshold_Element.Data.ToResoniteLinkField());
}

}
}

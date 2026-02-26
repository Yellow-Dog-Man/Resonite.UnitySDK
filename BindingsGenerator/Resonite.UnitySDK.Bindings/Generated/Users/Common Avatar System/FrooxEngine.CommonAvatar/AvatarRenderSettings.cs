
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarRenderSettings
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarRenderSettings")]
public partial class AvatarRenderSettings : global::FrooxEngine.Component, global::FrooxEngine.IRenderSettingsSource, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::System.Nullable<global::System.Single> NearClip { get => NearClip_Element.Data; set => NearClip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> NearClip_Element = new();
public global::System.Nullable<global::System.Single> FarClip { get => FarClip_Element.Data; set => FarClip_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::System.Single>>, global::System.Nullable<global::System.Single>> FarClip_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("NearClip", NearClip_Element.Data.ToResoniteLinkField());
members.Add("FarClip", FarClip_Element.Data.ToResoniteLinkField());
}

}
}

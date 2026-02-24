
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarRenderSettings
// Generated on: úterý 24. února 2026 18:20:31
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarRenderSettings")]
public partial class AvatarRenderSettings : global::FrooxEngine.Component, global::FrooxEngine.IRenderSettingsSource, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::System.Nullable<global::System.Single> NearClip;
public global::System.Nullable<global::System.Single> FarClip;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("NearClip", NearClip.ToResoniteLinkField());
members.Add("FarClip", FarClip.ToResoniteLinkField());
}

}
}

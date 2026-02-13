
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarRenderSettings
// Generated on: pátek 13. února 2026 23:23:19
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarRenderSettings")]
public partial class AvatarRenderSettings : global::FrooxEngine.Component, global::FrooxEngine.IRenderSettingsSource, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::System.Nullable<global::System.Single> NearClip;
public global::System.Nullable<global::System.Single> FarClip;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("NearClip", NearClip.ToResoniteLinkField());
members.Add("FarClip", FarClip.ToResoniteLinkField());
}

}
}

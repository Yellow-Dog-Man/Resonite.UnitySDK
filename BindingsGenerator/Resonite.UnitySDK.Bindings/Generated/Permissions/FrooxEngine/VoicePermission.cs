
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VoicePermission
// Generated on: středa 25. února 2026 16:13:11
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VoicePermission")]
public partial class VoicePermission : global::FrooxEngine.PermissionsComponent

{
    public global::FrooxEngine.VoiceMode MaxAllowedVoiceMode;
public global::System.Boolean AllowChangeOtherUsers;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxAllowedVoiceMode", MaxAllowedVoiceMode.ToResoniteLinkField());
members.Add("AllowChangeOtherUsers", AllowChangeOtherUsers.ToResoniteLinkField());
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VoicePermission
// Generated on: čtvrtek 26. února 2026 10:03:41
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
    public global::FrooxEngine.VoiceMode MaxAllowedVoiceMode { get => MaxAllowedVoiceMode_Element.Data; set => MaxAllowedVoiceMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VoiceMode>, global::FrooxEngine.VoiceMode> MaxAllowedVoiceMode_Element = new();
public global::System.Boolean AllowChangeOtherUsers { get => AllowChangeOtherUsers_Element.Data; set => AllowChangeOtherUsers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowChangeOtherUsers_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("MaxAllowedVoiceMode", MaxAllowedVoiceMode_Element.Data.ToResoniteLinkField());
members.Add("AllowChangeOtherUsers", AllowChangeOtherUsers_Element.Data.ToResoniteLinkField());
}

}
}

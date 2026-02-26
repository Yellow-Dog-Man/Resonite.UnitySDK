
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TwitchInterfaceSettings
// Generated on: čtvrtek 26. února 2026 12:28:14
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TwitchInterfaceSettings")]
public partial class TwitchInterfaceSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.TwitchInterfaceSettings>

{
    public global::System.String ChannelName { get => ChannelName_Element.Data; set => ChannelName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> ChannelName_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ChannelName", ChannelName_Element.ToLinkField(context));
}

}
}

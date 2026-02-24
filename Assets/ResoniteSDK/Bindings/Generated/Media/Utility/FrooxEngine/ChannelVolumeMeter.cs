
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ChannelVolumeMeter
// Generated on: úterý 24. února 2026 18:17:52
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ChannelVolumeMeter")]
public partial class ChannelVolumeMeter : global::FrooxEngine.VolumeMeterBase

{
    public global::System.Int32 CurrentChannels;
public System.Collections.Generic.List<global::System.Single> ChannelVolumes;
public global::System.Boolean DoNotRemoveExcessFields;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CurrentChannels", CurrentChannels.ToResoniteLinkField());
members.Add("ChannelVolumes", new ResoniteLink.SyncList()
{
    Elements = ChannelVolumes.ConvertList(m => m.ToResoniteLinkField())
});
members.Add("DoNotRemoveExcessFields", DoNotRemoveExcessFields.ToResoniteLinkField());
}

}
}

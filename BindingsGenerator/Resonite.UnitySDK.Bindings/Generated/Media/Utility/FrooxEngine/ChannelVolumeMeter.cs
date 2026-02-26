
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ChannelVolumeMeter
// Generated on: čtvrtek 26. února 2026 15:08:01
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::System.Int32 CurrentChannels { get => CurrentChannels_Element.Data; set => CurrentChannels_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> CurrentChannels_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncList<global::FrooxEngine.RawOutput<global::System.Single>>, global::System.Single, Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single>> ChannelVolumes = new();
public global::System.Boolean DoNotRemoveExcessFields { get => DoNotRemoveExcessFields_Element.Data; set => DoNotRemoveExcessFields_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DoNotRemoveExcessFields_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CurrentChannels", CurrentChannels_Element.ToLinkField(context));
members.Add("ChannelVolumes", ChannelVolumes.ToLinkList(context, m => m.ToLinkField(context)));
members.Add("DoNotRemoveExcessFields", DoNotRemoveExcessFields_Element.ToLinkField(context));
}

}
}

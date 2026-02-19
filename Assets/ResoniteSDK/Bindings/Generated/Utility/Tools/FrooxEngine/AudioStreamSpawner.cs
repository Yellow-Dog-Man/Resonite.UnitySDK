
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioStreamSpawner
// Generated on: čtvrtek 19. února 2026 8:00:34
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioStreamSpawner")]
public partial class AudioStreamSpawner : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::System.Single BitrateKbps;
public global::System.String DeviceID;
public global::System.String _bitrateString;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BitrateKbps", BitrateKbps.ToResoniteLinkField());
members.Add("DeviceID", DeviceID.ToResoniteLinkField());
members.Add("_bitrateString", _bitrateString.ToResoniteLinkField());
}

}
}

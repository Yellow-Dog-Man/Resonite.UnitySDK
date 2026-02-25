
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioStreamSpawner
// Generated on: středa 25. února 2026 16:14:47
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

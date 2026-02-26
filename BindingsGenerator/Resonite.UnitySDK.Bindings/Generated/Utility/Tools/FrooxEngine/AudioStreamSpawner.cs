
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioStreamSpawner
// Generated on: čtvrtek 26. února 2026 12:28:16
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioStreamSpawner")]
public partial class AudioStreamSpawner : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::System.Single BitrateKbps { get => BitrateKbps_Element.Data; set => BitrateKbps_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BitrateKbps_Element = new();
public global::System.String DeviceID { get => DeviceID_Element.Data; set => DeviceID_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> DeviceID_Element = new();
public global::System.String _bitrateString { get => _bitrateString_Element.Data; set => _bitrateString_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> _bitrateString_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BitrateKbps", BitrateKbps_Element.ToLinkField(context));
members.Add("DeviceID", DeviceID_Element.ToLinkField(context));
members.Add("_bitrateString", _bitrateString_Element.ToLinkField(context));
}

}
}

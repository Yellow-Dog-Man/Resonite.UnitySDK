
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioDeviceIndexFinder
// Generated on: čtvrtek 26. února 2026 12:26:52
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioDeviceIndexFinder")]
public partial class AudioDeviceIndexFinder : global::FrooxEngine.Component

{
    public global::System.Int32 DeviceIndex { get => DeviceIndex_Element.Data; set => DeviceIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> DeviceIndex_Element = new();
public global::System.String DeviceName { get => DeviceName_Element.Data; set => DeviceName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> DeviceName_Element = new();
public global::System.Boolean CaseSensitive { get => CaseSensitive_Element.Data; set => CaseSensitive_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CaseSensitive_Element = new();
public global::System.Boolean AllowPartialMatch { get => AllowPartialMatch_Element.Data; set => AllowPartialMatch_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowPartialMatch_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DeviceIndex", DeviceIndex_Element.ToLinkField(context));
members.Add("DeviceName", DeviceName_Element.ToLinkField(context));
members.Add("CaseSensitive", CaseSensitive_Element.ToLinkField(context));
members.Add("AllowPartialMatch", AllowPartialMatch_Element.ToLinkField(context));
}

}
}

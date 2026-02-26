
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AudioInputDeviceInfo
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AudioInputDeviceInfo")]
public partial class AudioInputDeviceInfo : global::FrooxEngine.Component

{
    public global::System.Int32 DeviceIndex { get => DeviceIndex_Element.Data; set => DeviceIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> DeviceIndex_Element = new();
public global::System.String DeviceName { get => DeviceName_Element.Data; set => DeviceName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> DeviceName_Element = new();
public global::System.Boolean IsAppDefault { get => IsAppDefault_Element.Data; set => IsAppDefault_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsAppDefault_Element = new();
public global::System.Boolean IsSystemDefault { get => IsSystemDefault_Element.Data; set => IsSystemDefault_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsSystemDefault_Element = new();
public global::FrooxEngine.AudioInputType DeviceType { get => DeviceType_Element.Data; set => DeviceType_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.AudioInputType>, global::FrooxEngine.AudioInputType> DeviceType_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DeviceIndex", DeviceIndex_Element.ToLinkField(context));
members.Add("DeviceName", DeviceName_Element.ToLinkField(context));
members.Add("IsAppDefault", IsAppDefault_Element.ToLinkField(context));
members.Add("IsSystemDefault", IsSystemDefault_Element.ToLinkField(context));
members.Add("DeviceType", DeviceType_Element.ToLinkField(context));
}

}
}

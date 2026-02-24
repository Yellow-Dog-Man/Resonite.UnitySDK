
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GiggleTechSettings+Device
// Generated on: úterý 24. února 2026 18:20:22
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
    public partial class GiggleTechSettings
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GiggleTechSettings+Device")]
public partial class Device : global::FrooxEngine.SyncObject

{
    public global::System.String IP;
public global::System.Boolean IsConnected;
public global::System.Boolean UseDevice;
public global::System.Boolean AlwaysTreatAsConnected;
public global::System.String CustomName;
public global::System.Single IntensityScale;
public global::System.Single MinimumIntensity;
public global::System.Single InitialActivationIntensity;
public global::FrooxEngine.HapticPointMapping HapticPointMapping;
public global::System.Int32 HapticPointIndex;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IP", IP.ToResoniteLinkField());
members.Add("IsConnected", IsConnected.ToResoniteLinkField());
members.Add("UseDevice", UseDevice.ToResoniteLinkField());
members.Add("AlwaysTreatAsConnected", AlwaysTreatAsConnected.ToResoniteLinkField());
members.Add("CustomName", CustomName.ToResoniteLinkField());
members.Add("IntensityScale", IntensityScale.ToResoniteLinkField());
members.Add("MinimumIntensity", MinimumIntensity.ToResoniteLinkField());
members.Add("InitialActivationIntensity", InitialActivationIntensity.ToResoniteLinkField());
members.Add("HapticPointMapping", new ResoniteLink.SyncObject() { Members = HapticPointMapping.CollectMembers(context) });
members.Add("HapticPointIndex", HapticPointIndex.ToResoniteLinkField());
}

}
            }
}

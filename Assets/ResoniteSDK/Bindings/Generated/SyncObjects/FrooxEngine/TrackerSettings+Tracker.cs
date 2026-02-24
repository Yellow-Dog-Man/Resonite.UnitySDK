
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TrackerSettings+Tracker
// Generated on: úterý 24. února 2026 18:20:29
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
    public partial class TrackerSettings
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TrackerSettings+Tracker")]
public partial class Tracker : global::FrooxEngine.SyncObject

{
    public global::System.Boolean UseTracker;
public global::System.Boolean FreezeTracking;
public global::System.Boolean IsConnected;
public global::System.String CustomName;
public global::Renderite.Shared.BodyNode MappedBodyNode;
public UnityEngine.Vector3 MappedPosition;
public UnityEngine.Quaternion MappedRotation;
public global::System.Boolean UseInVR;
public global::System.Boolean UseInDesktop;
public global::System.String TrackerID;
public global::System.Single TrackerBattery;
public global::System.Boolean TrackerIsCharging;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseTracker", UseTracker.ToResoniteLinkField());
members.Add("FreezeTracking", FreezeTracking.ToResoniteLinkField());
members.Add("IsConnected", IsConnected.ToResoniteLinkField());
members.Add("CustomName", CustomName.ToResoniteLinkField());
members.Add("MappedBodyNode", MappedBodyNode.ToResoniteLinkField());
members.Add("MappedPosition", MappedPosition.ToResoniteLinkField());
members.Add("MappedRotation", MappedRotation.ToResoniteLinkField());
members.Add("UseInVR", UseInVR.ToResoniteLinkField());
members.Add("UseInDesktop", UseInDesktop.ToResoniteLinkField());
members.Add("TrackerID", TrackerID.ToResoniteLinkField());
members.Add("TrackerBattery", TrackerBattery.ToResoniteLinkField());
members.Add("TrackerIsCharging", TrackerIsCharging.ToResoniteLinkField());
}

}
            }
}

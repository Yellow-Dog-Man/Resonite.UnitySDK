
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TrackerSettings+Tracker
// Generated on: čtvrtek 26. února 2026 15:09:15
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
    public partial class TrackerSettings
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TrackerSettings+Tracker")]
public partial class Tracker : global::FrooxEngine.SyncObject

{
    public global::System.Boolean UseTracker { get => UseTracker_Element.Data; set => UseTracker_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseTracker_Element = new();
public global::System.Boolean FreezeTracking { get => FreezeTracking_Element.Data; set => FreezeTracking_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FreezeTracking_Element = new();
public global::System.Boolean IsConnected { get => IsConnected_Element.Data; set => IsConnected_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsConnected_Element = new();
public global::System.String CustomName { get => CustomName_Element.Data; set => CustomName_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> CustomName_Element = new();
public global::Renderite.Shared.BodyNode MappedBodyNode { get => MappedBodyNode_Element.Data; set => MappedBodyNode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.BodyNode>, global::Renderite.Shared.BodyNode> MappedBodyNode_Element = new();
public UnityEngine.Vector3 MappedPosition { get => MappedPosition_Element.Data; set => MappedPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> MappedPosition_Element = new();
public UnityEngine.Quaternion MappedRotation { get => MappedRotation_Element.Data; set => MappedRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> MappedRotation_Element = new();
public global::System.Boolean UseInVR { get => UseInVR_Element.Data; set => UseInVR_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseInVR_Element = new();
public global::System.Boolean UseInDesktop { get => UseInDesktop_Element.Data; set => UseInDesktop_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseInDesktop_Element = new();
public global::System.String TrackerID { get => TrackerID_Element.Data; set => TrackerID_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> TrackerID_Element = new();
public global::System.Single TrackerBattery { get => TrackerBattery_Element.Data; set => TrackerBattery_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TrackerBattery_Element = new();
public global::System.Boolean TrackerIsCharging { get => TrackerIsCharging_Element.Data; set => TrackerIsCharging_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> TrackerIsCharging_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("UseTracker", UseTracker_Element.ToLinkField(context));
members.Add("FreezeTracking", FreezeTracking_Element.ToLinkField(context));
members.Add("IsConnected", IsConnected_Element.ToLinkField(context));
members.Add("CustomName", CustomName_Element.ToLinkField(context));
members.Add("MappedBodyNode", MappedBodyNode_Element.ToLinkField(context));
members.Add("MappedPosition", MappedPosition_Element.ToLinkField(context));
members.Add("MappedRotation", MappedRotation_Element.ToLinkField(context));
members.Add("UseInVR", UseInVR_Element.ToLinkField(context));
members.Add("UseInDesktop", UseInDesktop_Element.ToLinkField(context));
members.Add("TrackerID", TrackerID_Element.ToLinkField(context));
members.Add("TrackerBattery", TrackerBattery_Element.ToLinkField(context));
members.Add("TrackerIsCharging", TrackerIsCharging_Element.ToLinkField(context));
}

}
            }
}

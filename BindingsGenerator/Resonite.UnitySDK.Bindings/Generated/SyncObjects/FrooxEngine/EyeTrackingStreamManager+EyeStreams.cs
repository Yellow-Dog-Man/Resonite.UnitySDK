
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.EyeTrackingStreamManager+EyeStreams
// Generated on: středa 25. února 2026 16:14:44
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
    public partial class EyeTrackingStreamManager
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.EyeTrackingStreamManager+EyeStreams")]
public partial class EyeStreams : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.ValueStream<global::System.Boolean> IsTracking;
public global::FrooxEngine.ValueStream<UnityEngine.Vector3> Position;
public global::FrooxEngine.ValueStream<UnityEngine.Vector3> Direction;
public global::FrooxEngine.ValueStream<global::System.Single> Openness;
public global::FrooxEngine.ValueStream<global::System.Single> Widen;
public global::FrooxEngine.ValueStream<global::System.Single> Squeeze;
public global::FrooxEngine.ValueStream<global::System.Single> Frown;
public global::FrooxEngine.ValueStream<global::System.Single> InnerBrowVertical;
public global::FrooxEngine.ValueStream<global::System.Single> OuterBrowVertical;
public global::FrooxEngine.ValueStream<global::System.Single> PupilDiameter;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsTracking", IsTracking.ToResoniteReference(context));
members.Add("Position", Position.ToResoniteReference(context));
members.Add("Direction", Direction.ToResoniteReference(context));
members.Add("Openness", Openness.ToResoniteReference(context));
members.Add("Widen", Widen.ToResoniteReference(context));
members.Add("Squeeze", Squeeze.ToResoniteReference(context));
members.Add("Frown", Frown.ToResoniteReference(context));
members.Add("InnerBrowVertical", InnerBrowVertical.ToResoniteReference(context));
members.Add("OuterBrowVertical", OuterBrowVertical.ToResoniteReference(context));
members.Add("PupilDiameter", PupilDiameter.ToResoniteReference(context));
}

}
            }
}

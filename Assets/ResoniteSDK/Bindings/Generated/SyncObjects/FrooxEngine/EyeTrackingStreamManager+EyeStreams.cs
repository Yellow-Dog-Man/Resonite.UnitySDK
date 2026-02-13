
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.EyeTrackingStreamManager+EyeStreams
// Generated on: pátek 13. února 2026 23:23:19
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("IsTracking", new ResoniteLink.Reference() { });
members.Add("Position", new ResoniteLink.Reference() { });
members.Add("Direction", new ResoniteLink.Reference() { });
members.Add("Openness", new ResoniteLink.Reference() { });
members.Add("Widen", new ResoniteLink.Reference() { });
members.Add("Squeeze", new ResoniteLink.Reference() { });
members.Add("Frown", new ResoniteLink.Reference() { });
members.Add("InnerBrowVertical", new ResoniteLink.Reference() { });
members.Add("OuterBrowVertical", new ResoniteLink.Reference() { });
members.Add("PupilDiameter", new ResoniteLink.Reference() { });
}

}
            }
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.EyeTrackingStreamManager+EyeStreams
// Generated on: čtvrtek 26. února 2026 10:04:49
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
    public global::FrooxEngine.ValueStream<global::System.Boolean> IsTracking { get => IsTracking_Element.Data; set => IsTracking_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Boolean>>, global::FrooxEngine.ValueStream<global::System.Boolean>> IsTracking_Element = new();
public global::FrooxEngine.ValueStream<UnityEngine.Vector3> Position { get => Position_Element.Data; set => Position_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<UnityEngine.Vector3>>, global::FrooxEngine.ValueStream<UnityEngine.Vector3>> Position_Element = new();
public global::FrooxEngine.ValueStream<UnityEngine.Vector3> Direction { get => Direction_Element.Data; set => Direction_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<UnityEngine.Vector3>>, global::FrooxEngine.ValueStream<UnityEngine.Vector3>> Direction_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> Openness { get => Openness_Element.Data; set => Openness_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> Openness_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> Widen { get => Widen_Element.Data; set => Widen_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> Widen_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> Squeeze { get => Squeeze_Element.Data; set => Squeeze_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> Squeeze_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> Frown { get => Frown_Element.Data; set => Frown_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> Frown_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> InnerBrowVertical { get => InnerBrowVertical_Element.Data; set => InnerBrowVertical_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> InnerBrowVertical_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> OuterBrowVertical { get => OuterBrowVertical_Element.Data; set => OuterBrowVertical_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> OuterBrowVertical_Element = new();
public global::FrooxEngine.ValueStream<global::System.Single> PupilDiameter { get => PupilDiameter_Element.Data; set => PupilDiameter_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ValueStream<global::System.Single>>, global::FrooxEngine.ValueStream<global::System.Single>> PupilDiameter_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsTracking", IsTracking_Element.Data.ToResoniteReference(context));
members.Add("Position", Position_Element.Data.ToResoniteReference(context));
members.Add("Direction", Direction_Element.Data.ToResoniteReference(context));
members.Add("Openness", Openness_Element.Data.ToResoniteReference(context));
members.Add("Widen", Widen_Element.Data.ToResoniteReference(context));
members.Add("Squeeze", Squeeze_Element.Data.ToResoniteReference(context));
members.Add("Frown", Frown_Element.Data.ToResoniteReference(context));
members.Add("InnerBrowVertical", InnerBrowVertical_Element.Data.ToResoniteReference(context));
members.Add("OuterBrowVertical", OuterBrowVertical_Element.Data.ToResoniteReference(context));
members.Add("PupilDiameter", PupilDiameter_Element.Data.ToResoniteReference(context));
}

}
            }
}

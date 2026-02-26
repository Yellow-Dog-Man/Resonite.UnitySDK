
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarRawEyeData+EyeData
// Generated on: čtvrtek 26. února 2026 12:28:15
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    public partial class AvatarRawEyeData
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarRawEyeData+EyeData")]
public partial class EyeData : global::FrooxEngine.SyncObject

{
    public global::System.Boolean IsTracking { get => IsTracking_Element.Data; set => IsTracking_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsTracking_Element = new();
public UnityEngine.Vector3 Origin { get => Origin_Element.Data; set => Origin_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Origin_Element = new();
public UnityEngine.Vector3 Direction { get => Direction_Element.Data; set => Direction_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Direction_Element = new();
public global::System.Single PupilDiameter { get => PupilDiameter_Element.Data; set => PupilDiameter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> PupilDiameter_Element = new();
public global::System.Single Openness { get => Openness_Element.Data; set => Openness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Openness_Element = new();
public global::System.Single Widen { get => Widen_Element.Data; set => Widen_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Widen_Element = new();
public global::System.Single Squeeze { get => Squeeze_Element.Data; set => Squeeze_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Squeeze_Element = new();
public global::System.Single Frown { get => Frown_Element.Data; set => Frown_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Frown_Element = new();
public global::System.Single InnerBrowVertical { get => InnerBrowVertical_Element.Data; set => InnerBrowVertical_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InnerBrowVertical_Element = new();
public global::System.Single OuterBrowVertical { get => OuterBrowVertical_Element.Data; set => OuterBrowVertical_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OuterBrowVertical_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsTracking", IsTracking_Element.ToLinkField(context));
members.Add("Origin", Origin_Element.ToLinkField(context));
members.Add("Direction", Direction_Element.ToLinkField(context));
members.Add("PupilDiameter", PupilDiameter_Element.ToLinkField(context));
members.Add("Openness", Openness_Element.ToLinkField(context));
members.Add("Widen", Widen_Element.ToLinkField(context));
members.Add("Squeeze", Squeeze_Element.ToLinkField(context));
members.Add("Frown", Frown_Element.ToLinkField(context));
members.Add("InnerBrowVertical", InnerBrowVertical_Element.ToLinkField(context));
members.Add("OuterBrowVertical", OuterBrowVertical_Element.ToLinkField(context));
}

}
            }
}

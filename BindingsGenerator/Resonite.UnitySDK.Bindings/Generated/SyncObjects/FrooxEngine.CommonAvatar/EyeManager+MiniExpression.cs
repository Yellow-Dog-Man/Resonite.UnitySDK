
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.EyeManager+MiniExpression
// Generated on: čtvrtek 26. února 2026 10:04:44
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    public partial class EyeManager
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.EyeManager+MiniExpression")]
public partial class MiniExpression : global::FrooxEngine.SyncObject

{
    public global::System.Single Weight { get => Weight_Element.Data; set => Weight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Weight_Element = new();
public UnityEngine.Vector3 Direction { get => Direction_Element.Data; set => Direction_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Direction_Element = new();
public global::System.Single MinDuration { get => MinDuration_Element.Data; set => MinDuration_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MinDuration_Element = new();
public global::System.Single MaxDuration { get => MaxDuration_Element.Data; set => MaxDuration_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> MaxDuration_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Weight", Weight_Element.Data.ToResoniteLinkField());
members.Add("Direction", Direction_Element.Data.ToResoniteLinkField());
members.Add("MinDuration", MinDuration_Element.Data.ToResoniteLinkField());
members.Add("MaxDuration", MaxDuration_Element.Data.ToResoniteLinkField());
}

}
            }
}

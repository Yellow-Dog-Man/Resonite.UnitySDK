
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.EyeManager+MiniExpression
// Generated on: středa 25. února 2026 16:14:37
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
    public global::System.Single Weight;
public UnityEngine.Vector3 Direction;
public global::System.Single MinDuration;
public global::System.Single MaxDuration;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Weight", Weight.ToResoniteLinkField());
members.Add("Direction", Direction.ToResoniteLinkField());
members.Add("MinDuration", MinDuration.ToResoniteLinkField());
members.Add("MaxDuration", MaxDuration.ToResoniteLinkField());
}

}
            }
}

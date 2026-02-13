
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.EyeManager+MiniExpression
// Generated on: pátek 13. února 2026 5:52:31
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Weight", Weight.ToResoniteLinkField());
members.Add("Direction", Direction.ToResoniteLinkField());
members.Add("MinDuration", MinDuration.ToResoniteLinkField());
members.Add("MaxDuration", MaxDuration.ToResoniteLinkField());
}

}
            }
}

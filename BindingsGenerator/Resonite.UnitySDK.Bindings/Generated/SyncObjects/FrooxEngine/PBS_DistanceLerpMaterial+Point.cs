
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_DistanceLerpMaterial+Point
// Generated on: středa 25. února 2026 16:13:03
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
    public partial class PBS_DistanceLerpMaterial
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_DistanceLerpMaterial+Point")]
public partial class Point : global::FrooxEngine.SyncObject

{
    public UnityEngine.Vector3 Position;
public UnityEngine.ColorX Tint;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Position", Position.ToResoniteLinkField());
members.Add("Tint", Tint.ToResoniteLinkField());
}

}
            }
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_Slice+Slicer
// Generated on: čtvrtek 19. února 2026 7:58:50
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public partial class PBS_Slice
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_Slice+Slicer")]
public partial class Slicer : global::FrooxEngine.SyncObject

{
    public UnityEngine.Vector3 Position;
public UnityEngine.Vector3 Normal;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Position", Position.ToResoniteLinkField());
members.Add("Normal", Normal.ToResoniteLinkField());
}

}
            }
}

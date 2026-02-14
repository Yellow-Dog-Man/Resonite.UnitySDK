
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_Slice+Slicer
// Generated on: sobota 14. února 2026 8:56:56
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GenericSlicer+SliceDrive
// Generated on: středa 25. února 2026 16:14:25
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
    public partial class GenericSlicer
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GenericSlicer+SliceDrive")]
public partial class SliceDrive : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.IField<UnityEngine.Vector3> Position;
public global::FrooxEngine.IField<UnityEngine.Vector3> Normal;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Position", Position.ToResoniteReference(context));
members.Add("Normal", Normal.ToResoniteReference(context));
}

}
            }
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicBlendShapeDriver+BlendShape
// Generated on: pátek 13. února 2026 5:52:25
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public partial class DynamicBlendShapeDriver
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicBlendShapeDriver+BlendShape")]
public partial class BlendShape : global::FrooxEngine.SyncObject

{
    public global::System.String BlendShapeName;
public global::System.Single Value;
public global::FrooxEngine.IField<global::System.Single> _drive;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("BlendShapeName", BlendShapeName.ToResoniteLinkField());
members.Add("Value", Value.ToResoniteLinkField());
members.Add("_drive", new ResoniteLink.Reference() { });
}

}
            }
}

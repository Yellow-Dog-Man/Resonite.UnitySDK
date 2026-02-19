
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DynamicBlendShapeDriver+BlendShape
// Generated on: čtvrtek 19. února 2026 8:00:23
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
    public partial class DynamicBlendShapeDriver
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DynamicBlendShapeDriver+BlendShape")]
public partial class BlendShape : global::FrooxEngine.SyncObject

{
    public global::System.String BlendShapeName;
public global::System.Single Value;
public global::FrooxEngine.IField<global::System.Single> _drive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("BlendShapeName", BlendShapeName.ToResoniteLinkField());
members.Add("Value", Value.ToResoniteLinkField());
members.Add("_drive", _drive.ToResoniteReference(context));
}

}
            }
}

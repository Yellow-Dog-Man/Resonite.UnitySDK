
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Assets.DebugDirectionCubemap
// Generated on: pondělí 2. března 2026 17:52:25
// Resonite version: 2026.3.2.1000
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.Assets
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Assets.DebugDirectionCubemap")]
public partial class DebugDirectionCubemap : global::FrooxEngine.ProceduralCubemap

{
    public UnityEngine.Vector3Bool RGB_Mask { get => RGB_Mask_Element.Data; set => RGB_Mask_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3Bool>, UnityEngine.Vector3Bool> RGB_Mask_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("RGB_Mask", RGB_Mask_Element.ToLinkField(context));
}

}
}

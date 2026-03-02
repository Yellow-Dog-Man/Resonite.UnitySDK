
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MaterialApplyPolicy
// Generated on: pondělí 2. března 2026 17:52:26
// Resonite version: 2026.3.2.1000
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MaterialApplyPolicy")]
public partial class MaterialApplyPolicy : global::FrooxEngine.Component, global::FrooxEngine.IMaterialApplyPolicy

{
    public global::System.Boolean CanApply { get => CanApply_Element.Data; set => CanApply_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CanApply_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CanApply", CanApply_Element.ToLinkField(context));
}

}
}

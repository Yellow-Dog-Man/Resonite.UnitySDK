
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshVisibilityToggleTool
// Generated on: úterý 24. února 2026 18:20:11
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MeshVisibilityToggleTool")]
public partial class MeshVisibilityToggleTool : global::FrooxEngine.BuilderActionTool

{
    public global::System.Nullable<global::Renderite.Shared.ShadowCastMode> SetShadowCastMode;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SetShadowCastMode", SetShadowCastMode.ToResoniteLinkField());
}

}
}

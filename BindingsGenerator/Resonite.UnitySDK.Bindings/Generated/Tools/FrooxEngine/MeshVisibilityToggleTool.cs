
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshVisibilityToggleTool
// Generated on: čtvrtek 26. února 2026 15:09:06
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::System.Nullable<global::Renderite.Shared.ShadowCastMode> SetShadowCastMode { get => SetShadowCastMode_Element.Data; set => SetShadowCastMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<global::Renderite.Shared.ShadowCastMode>>, global::System.Nullable<global::Renderite.Shared.ShadowCastMode>> SetShadowCastMode_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SetShadowCastMode", SetShadowCastMode_Element.ToLinkField(context));
}

}
}

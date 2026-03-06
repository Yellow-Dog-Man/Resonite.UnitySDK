
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CopyTransformFromWorld
// Generated on: pátek 6. března 2026 14:19:08
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CopyTransformFromWorld")]
public partial class CopyTransformFromWorld : global::FrooxEngine.Component

{
    public global::System.Boolean CopyPosition { get => CopyPosition_Element.Data; set => CopyPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CopyPosition_Element = new();
public global::System.Boolean CopyRotation { get => CopyRotation_Element.Data; set => CopyRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CopyRotation_Element = new();
public global::System.Boolean CopyScale { get => CopyScale_Element.Data; set => CopyScale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CopyScale_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CopyPosition", CopyPosition_Element.ToLinkField(context));
members.Add("CopyRotation", CopyRotation_Element.ToLinkField(context));
members.Add("CopyScale", CopyScale_Element.ToLinkField(context));
}

}
}

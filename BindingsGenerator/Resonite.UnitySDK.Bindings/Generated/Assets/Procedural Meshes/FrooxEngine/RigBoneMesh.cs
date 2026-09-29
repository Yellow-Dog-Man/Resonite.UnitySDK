
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RigBoneMesh
// Generated on: pátek 14. srpna 2026 21:54:00
// Resonite version: 2026.8.12.1196
// Resonite Link Version: 0.13.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RigBoneMesh")]
public partial class RigBoneMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Length { get => Length_Element.Data; set => Length_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Length_Element = new();
public global::System.Single Width { get => Width_Element.Data; set => Width_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Width_Element = new();
public global::System.Single NormalizedSplitPosition { get => NormalizedSplitPosition_Element.Data; set => NormalizedSplitPosition_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NormalizedSplitPosition_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Length", Length_Element.ToLinkField(context));
members.Add("Width", Width_Element.ToLinkField(context));
members.Add("NormalizedSplitPosition", NormalizedSplitPosition_Element.ToLinkField(context));
}

}
}

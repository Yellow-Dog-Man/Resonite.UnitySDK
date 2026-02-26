
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BevelStripeMesh
// Generated on: čtvrtek 26. února 2026 12:26:51
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BevelStripeMesh")]
public partial class BevelStripeMesh : global::FrooxEngine.ProceduralMesh

{
    public global::System.Single Width { get => Width_Element.Data; set => Width_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Width_Element = new();
public global::System.Single Height { get => Height_Element.Data; set => Height_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Height_Element = new();
public global::System.Single Thickness { get => Thickness_Element.Data; set => Thickness_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Thickness_Element = new();
public global::System.Single SlantLeft { get => SlantLeft_Element.Data; set => SlantLeft_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SlantLeft_Element = new();
public global::System.Single SlantRight { get => SlantRight_Element.Data; set => SlantRight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SlantRight_Element = new();
public global::System.Boolean Relief { get => Relief_Element.Data; set => Relief_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Relief_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Width", Width_Element.ToLinkField(context));
members.Add("Height", Height_Element.ToLinkField(context));
members.Add("Thickness", Thickness_Element.ToLinkField(context));
members.Add("SlantLeft", SlantLeft_Element.ToLinkField(context));
members.Add("SlantRight", SlantRight_Element.ToLinkField(context));
members.Add("Relief", Relief_Element.ToLinkField(context));
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CheckerboardCubemap
// Generated on: čtvrtek 26. února 2026 15:07:54
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CheckerboardCubemap")]
public partial class CheckerboardCubemap : global::FrooxEngine.ProceduralCubemap

{
    public global::System.Int32 CheckerSize { get => CheckerSize_Element.Data; set => CheckerSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> CheckerSize_Element = new();
public UnityEngine.ColorX PosX_Color0 { get => PosX_Color0_Element.Data; set => PosX_Color0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> PosX_Color0_Element = new();
public UnityEngine.ColorX PosX_Color1 { get => PosX_Color1_Element.Data; set => PosX_Color1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> PosX_Color1_Element = new();
public UnityEngine.ColorX NegX_Color0 { get => NegX_Color0_Element.Data; set => NegX_Color0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> NegX_Color0_Element = new();
public UnityEngine.ColorX NegX_Color1 { get => NegX_Color1_Element.Data; set => NegX_Color1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> NegX_Color1_Element = new();
public UnityEngine.ColorX PosY_Color0 { get => PosY_Color0_Element.Data; set => PosY_Color0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> PosY_Color0_Element = new();
public UnityEngine.ColorX PosY_Color1 { get => PosY_Color1_Element.Data; set => PosY_Color1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> PosY_Color1_Element = new();
public UnityEngine.ColorX NegY_Color0 { get => NegY_Color0_Element.Data; set => NegY_Color0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> NegY_Color0_Element = new();
public UnityEngine.ColorX NegY_Color1 { get => NegY_Color1_Element.Data; set => NegY_Color1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> NegY_Color1_Element = new();
public UnityEngine.ColorX PosZ_Color0 { get => PosZ_Color0_Element.Data; set => PosZ_Color0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> PosZ_Color0_Element = new();
public UnityEngine.ColorX PosZ_Color1 { get => PosZ_Color1_Element.Data; set => PosZ_Color1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> PosZ_Color1_Element = new();
public UnityEngine.ColorX NegZ_Color0 { get => NegZ_Color0_Element.Data; set => NegZ_Color0_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> NegZ_Color0_Element = new();
public UnityEngine.ColorX NegZ_Color1 { get => NegZ_Color1_Element.Data; set => NegZ_Color1_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> NegZ_Color1_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CheckerSize", CheckerSize_Element.ToLinkField(context));
members.Add("PosX_Color0", PosX_Color0_Element.ToLinkField(context));
members.Add("PosX_Color1", PosX_Color1_Element.ToLinkField(context));
members.Add("NegX_Color0", NegX_Color0_Element.ToLinkField(context));
members.Add("NegX_Color1", NegX_Color1_Element.ToLinkField(context));
members.Add("PosY_Color0", PosY_Color0_Element.ToLinkField(context));
members.Add("PosY_Color1", PosY_Color1_Element.ToLinkField(context));
members.Add("NegY_Color0", NegY_Color0_Element.ToLinkField(context));
members.Add("NegY_Color1", NegY_Color1_Element.ToLinkField(context));
members.Add("PosZ_Color0", PosZ_Color0_Element.ToLinkField(context));
members.Add("PosZ_Color1", PosZ_Color1_Element.ToLinkField(context));
members.Add("NegZ_Color0", NegZ_Color0_Element.ToLinkField(context));
members.Add("NegZ_Color1", NegZ_Color1_Element.ToLinkField(context));
}

}
}

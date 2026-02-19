
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CheckerboardCubemap
// Generated on: čtvrtek 19. února 2026 7:58:52
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CheckerboardCubemap")]
public partial class CheckerboardCubemap : global::FrooxEngine.ProceduralCubemap

{
    public global::System.Int32 CheckerSize;
public UnityEngine.ColorX PosX_Color0;
public UnityEngine.ColorX PosX_Color1;
public UnityEngine.ColorX NegX_Color0;
public UnityEngine.ColorX NegX_Color1;
public UnityEngine.ColorX PosY_Color0;
public UnityEngine.ColorX PosY_Color1;
public UnityEngine.ColorX NegY_Color0;
public UnityEngine.ColorX NegY_Color1;
public UnityEngine.ColorX PosZ_Color0;
public UnityEngine.ColorX PosZ_Color1;
public UnityEngine.ColorX NegZ_Color0;
public UnityEngine.ColorX NegZ_Color1;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CheckerSize", CheckerSize.ToResoniteLinkField());
members.Add("PosX_Color0", PosX_Color0.ToResoniteLinkField());
members.Add("PosX_Color1", PosX_Color1.ToResoniteLinkField());
members.Add("NegX_Color0", NegX_Color0.ToResoniteLinkField());
members.Add("NegX_Color1", NegX_Color1.ToResoniteLinkField());
members.Add("PosY_Color0", PosY_Color0.ToResoniteLinkField());
members.Add("PosY_Color1", PosY_Color1.ToResoniteLinkField());
members.Add("NegY_Color0", NegY_Color0.ToResoniteLinkField());
members.Add("NegY_Color1", NegY_Color1.ToResoniteLinkField());
members.Add("PosZ_Color0", PosZ_Color0.ToResoniteLinkField());
members.Add("PosZ_Color1", PosZ_Color1.ToResoniteLinkField());
members.Add("NegZ_Color0", NegZ_Color0.ToResoniteLinkField());
members.Add("NegZ_Color1", NegZ_Color1.ToResoniteLinkField());
}

}
}

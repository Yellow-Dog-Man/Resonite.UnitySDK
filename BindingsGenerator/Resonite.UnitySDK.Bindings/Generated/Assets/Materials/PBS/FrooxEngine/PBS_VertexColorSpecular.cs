
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PBS_VertexColorSpecular
// Generated on: středa 25. února 2026 16:13:03
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PBS_VertexColorSpecular")]
public partial class PBS_VertexColorSpecular : global::FrooxEngine.PBS_VertexColor, global::FrooxEngine.IPBS_Specular

{
    public UnityEngine.ColorX SpecularColor;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> SpecularMap;
public global::FrooxEngine.PBS_VertexColorSpecular.ColorTarget VertexColorTarget;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _regular;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _transparent;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Shader> _transparentFront;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SpecularColor", SpecularColor.ToResoniteLinkField());
members.Add("SpecularMap", SpecularMap.ToResoniteReference(context));
members.Add("VertexColorTarget", VertexColorTarget.ToResoniteLinkField());
members.Add("_regular", _regular.ToResoniteReference(context));
members.Add("_transparent", _transparent.ToResoniteReference(context));
members.Add("_transparentFront", _transparentFront.ToResoniteReference(context));
}

}
}

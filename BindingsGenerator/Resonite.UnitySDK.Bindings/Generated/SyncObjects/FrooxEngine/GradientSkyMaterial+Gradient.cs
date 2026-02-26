
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GradientSkyMaterial+Gradient
// Generated on: čtvrtek 26. února 2026 10:03:34
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
    public partial class GradientSkyMaterial
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GradientSkyMaterial+Gradient")]
public partial class Gradient : global::FrooxEngine.SyncObject

{
    public UnityEngine.Vector3 Direction { get => Direction_Element.Data; set => Direction_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Direction_Element = new();
public UnityEngine.ColorX FromColor { get => FromColor_Element.Data; set => FromColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> FromColor_Element = new();
public UnityEngine.ColorX ToColor { get => ToColor_Element.Data; set => ToColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> ToColor_Element = new();
public global::System.Single Spread { get => Spread_Element.Data; set => Spread_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Spread_Element = new();
public global::System.Single From { get => From_Element.Data; set => From_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> From_Element = new();
public global::System.Single To { get => To_Element.Data; set => To_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> To_Element = new();
public global::System.Single Exp { get => Exp_Element.Data; set => Exp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Exp_Element = new();
public global::FrooxEngine.GradientSkyMaterial.Gradient.GradientBlendmode BlendMode { get => BlendMode_Element.Data; set => BlendMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.GradientSkyMaterial.Gradient.GradientBlendmode>, global::FrooxEngine.GradientSkyMaterial.Gradient.GradientBlendmode> BlendMode_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Direction", Direction_Element.Data.ToResoniteLinkField());
members.Add("FromColor", FromColor_Element.Data.ToResoniteLinkField());
members.Add("ToColor", ToColor_Element.Data.ToResoniteLinkField());
members.Add("Spread", Spread_Element.Data.ToResoniteLinkField());
members.Add("From", From_Element.Data.ToResoniteLinkField());
members.Add("To", To_Element.Data.ToResoniteLinkField());
members.Add("Exp", Exp_Element.Data.ToResoniteLinkField());
members.Add("BlendMode", BlendMode_Element.Data.ToResoniteLinkField());
}

}
            }
}

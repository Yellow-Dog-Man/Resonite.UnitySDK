
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GradientSkyMaterial+Gradient
// Generated on: úterý 24. února 2026 18:17:36
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
    public partial class GradientSkyMaterial
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GradientSkyMaterial+Gradient")]
public partial class Gradient : global::FrooxEngine.SyncObject

{
    public UnityEngine.Vector3 Direction;
public UnityEngine.ColorX FromColor;
public UnityEngine.ColorX ToColor;
public global::System.Single Spread;
public global::System.Single From;
public global::System.Single To;
public global::System.Single Exp;
public global::FrooxEngine.GradientSkyMaterial.Gradient.GradientBlendmode BlendMode;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Direction", Direction.ToResoniteLinkField());
members.Add("FromColor", FromColor.ToResoniteLinkField());
members.Add("ToColor", ToColor.ToResoniteLinkField());
members.Add("Spread", Spread.ToResoniteLinkField());
members.Add("From", From.ToResoniteLinkField());
members.Add("To", To.ToResoniteLinkField());
members.Add("Exp", Exp.ToResoniteLinkField());
members.Add("BlendMode", BlendMode.ToResoniteLinkField());
}

}
            }
}

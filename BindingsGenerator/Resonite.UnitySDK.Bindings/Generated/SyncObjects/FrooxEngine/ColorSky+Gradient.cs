
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ColorSky+Gradient
// Generated on: čtvrtek 26. února 2026 15:09:10
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
    public partial class ColorSky
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ColorSky+Gradient")]
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Direction", Direction_Element.ToLinkField(context));
members.Add("FromColor", FromColor_Element.ToLinkField(context));
members.Add("ToColor", ToColor_Element.ToLinkField(context));
members.Add("Spread", Spread_Element.ToLinkField(context));
members.Add("From", From_Element.ToLinkField(context));
members.Add("To", To_Element.ToLinkField(context));
members.Add("Exp", Exp_Element.ToLinkField(context));
}

}
            }
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ScaleObjectManager
// Generated on: čtvrtek 26. února 2026 12:28:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ScaleObjectManager")]
public partial class ScaleObjectManager : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public global::System.Single ScalePower { get => ScalePower_Element.Data; set => ScalePower_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ScalePower_Element = new();
public global::System.Single LowerBound { get => LowerBound_Element.Data; set => LowerBound_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LowerBound_Element = new();
public global::System.Single UpperBound { get => UpperBound_Element.Data; set => UpperBound_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> UpperBound_Element = new();
public global::System.Single FarSizeTransitionRange { get => FarSizeTransitionRange_Element.Data; set => FarSizeTransitionRange_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FarSizeTransitionRange_Element = new();
public global::System.Single FarSizeTransitionExp { get => FarSizeTransitionExp_Element.Data; set => FarSizeTransitionExp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FarSizeTransitionExp_Element = new();
public global::System.Single NearSizeTransitionRange { get => NearSizeTransitionRange_Element.Data; set => NearSizeTransitionRange_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NearSizeTransitionRange_Element = new();
public global::System.Single NearSizeTransitionExp { get => NearSizeTransitionExp_Element.Data; set => NearSizeTransitionExp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NearSizeTransitionExp_Element = new();
public global::System.Single FarOffsetTransitionRange { get => FarOffsetTransitionRange_Element.Data; set => FarOffsetTransitionRange_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FarOffsetTransitionRange_Element = new();
public global::System.Single FarOffsetTransitionExp { get => FarOffsetTransitionExp_Element.Data; set => FarOffsetTransitionExp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FarOffsetTransitionExp_Element = new();
public UnityEngine.Vector3 FarTransitionOffset { get => FarTransitionOffset_Element.Data; set => FarTransitionOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> FarTransitionOffset_Element = new();
public global::System.Single NearOffsetTransitionRange { get => NearOffsetTransitionRange_Element.Data; set => NearOffsetTransitionRange_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NearOffsetTransitionRange_Element = new();
public global::System.Single NearOffsetTransitionExp { get => NearOffsetTransitionExp_Element.Data; set => NearOffsetTransitionExp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> NearOffsetTransitionExp_Element = new();
public UnityEngine.Vector3 NearTransitionOffset { get => NearTransitionOffset_Element.Data; set => NearTransitionOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> NearTransitionOffset_Element = new();
public global::System.Single CenterOffsetRadius { get => CenterOffsetRadius_Element.Data; set => CenterOffsetRadius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CenterOffsetRadius_Element = new();
public global::System.Single OptimalDistance { get => OptimalDistance_Element.Data; set => OptimalDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OptimalDistance_Element = new();
public UnityEngine.Vector3 CoordinatePowerBase { get => CoordinatePowerBase_Element.Data; set => CoordinatePowerBase_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> CoordinatePowerBase_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ScalePower", ScalePower_Element.ToLinkField(context));
members.Add("LowerBound", LowerBound_Element.ToLinkField(context));
members.Add("UpperBound", UpperBound_Element.ToLinkField(context));
members.Add("FarSizeTransitionRange", FarSizeTransitionRange_Element.ToLinkField(context));
members.Add("FarSizeTransitionExp", FarSizeTransitionExp_Element.ToLinkField(context));
members.Add("NearSizeTransitionRange", NearSizeTransitionRange_Element.ToLinkField(context));
members.Add("NearSizeTransitionExp", NearSizeTransitionExp_Element.ToLinkField(context));
members.Add("FarOffsetTransitionRange", FarOffsetTransitionRange_Element.ToLinkField(context));
members.Add("FarOffsetTransitionExp", FarOffsetTransitionExp_Element.ToLinkField(context));
members.Add("FarTransitionOffset", FarTransitionOffset_Element.ToLinkField(context));
members.Add("NearOffsetTransitionRange", NearOffsetTransitionRange_Element.ToLinkField(context));
members.Add("NearOffsetTransitionExp", NearOffsetTransitionExp_Element.ToLinkField(context));
members.Add("NearTransitionOffset", NearTransitionOffset_Element.ToLinkField(context));
members.Add("CenterOffsetRadius", CenterOffsetRadius_Element.ToLinkField(context));
members.Add("OptimalDistance", OptimalDistance_Element.ToLinkField(context));
members.Add("CoordinatePowerBase", CoordinatePowerBase_Element.ToLinkField(context));
}

}
}

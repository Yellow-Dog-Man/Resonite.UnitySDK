
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotoMetadata
// Generated on: čtvrtek 26. února 2026 15:07:58
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotoMetadata")]
public partial class PhotoMetadata : global::FrooxEngine.AssetMetadata

{
    public global::System.String CameraManufacturer { get => CameraManufacturer_Element.Data; set => CameraManufacturer_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> CameraManufacturer_Element = new();
public global::System.String CameraModel { get => CameraModel_Element.Data; set => CameraModel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> CameraModel_Element = new();
public global::System.Single CameraFOV { get => CameraFOV_Element.Data; set => CameraFOV_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> CameraFOV_Element = new();
public global::System.Boolean Is360 { get => Is360_Element.Data; set => Is360_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Is360_Element = new();
public global::Elements.Core.StereoLayout StereoLayout { get => StereoLayout_Element.Data; set => StereoLayout_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Core.StereoLayout>, global::Elements.Core.StereoLayout> StereoLayout_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CameraManufacturer", CameraManufacturer_Element.ToLinkField(context));
members.Add("CameraModel", CameraModel_Element.ToLinkField(context));
members.Add("CameraFOV", CameraFOV_Element.ToLinkField(context));
members.Add("Is360", Is360_Element.ToLinkField(context));
members.Add("StereoLayout", StereoLayout_Element.ToLinkField(context));
}

}
}

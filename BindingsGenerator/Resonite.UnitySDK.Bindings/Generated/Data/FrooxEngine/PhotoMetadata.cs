
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PhotoMetadata
// Generated on: středa 25. února 2026 16:13:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PhotoMetadata")]
public partial class PhotoMetadata : global::FrooxEngine.AssetMetadata

{
    public global::System.String CameraManufacturer;
public global::System.String CameraModel;
public global::System.Single CameraFOV;
public global::System.Boolean Is360;
public global::Elements.Core.StereoLayout StereoLayout;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CameraManufacturer", CameraManufacturer.ToResoniteLinkField());
members.Add("CameraModel", CameraModel.ToResoniteLinkField());
members.Add("CameraFOV", CameraFOV.ToResoniteLinkField());
members.Add("Is360", Is360.ToResoniteLinkField());
members.Add("StereoLayout", StereoLayout.ToResoniteLinkField());
}

}
}

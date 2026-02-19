
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ImageImportDialog
// Generated on: čtvrtek 19. února 2026 8:00:28
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ImageImportDialog")]
public partial class ImageImportDialog : global::FrooxEngine.ImportDialog

{
    public global::FrooxEngine.ImageProjection _projection;
public global::Elements.Core.StereoLayout _layout;
public global::System.Boolean _screenshot;
public global::System.Boolean _pointFiltering;
public global::System.Boolean _uncompressed;
public global::System.Boolean _alphaBleed;
public global::System.Boolean _lut;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_projection", _projection.ToResoniteLinkField());
members.Add("_layout", _layout.ToResoniteLinkField());
members.Add("_screenshot", _screenshot.ToResoniteLinkField());
members.Add("_pointFiltering", _pointFiltering.ToResoniteLinkField());
members.Add("_uncompressed", _uncompressed.ToResoniteLinkField());
members.Add("_alphaBleed", _alphaBleed.ToResoniteLinkField());
members.Add("_lut", _lut.ToResoniteLinkField());
}

}
}

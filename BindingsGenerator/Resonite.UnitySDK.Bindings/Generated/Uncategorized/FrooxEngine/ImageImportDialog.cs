
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ImageImportDialog
// Generated on: čtvrtek 26. února 2026 15:09:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ImageImportDialog")]
public partial class ImageImportDialog : global::FrooxEngine.ImportDialog

{
    public global::FrooxEngine.ImageProjection _projection { get => _projection_Element.Data; set => _projection_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ImageProjection>, global::FrooxEngine.ImageProjection> _projection_Element = new();
public global::Elements.Core.StereoLayout _layout { get => _layout_Element.Data; set => _layout_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Core.StereoLayout>, global::Elements.Core.StereoLayout> _layout_Element = new();
public global::System.Boolean _screenshot { get => _screenshot_Element.Data; set => _screenshot_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _screenshot_Element = new();
public global::System.Boolean _pointFiltering { get => _pointFiltering_Element.Data; set => _pointFiltering_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _pointFiltering_Element = new();
public global::System.Boolean _uncompressed { get => _uncompressed_Element.Data; set => _uncompressed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _uncompressed_Element = new();
public global::System.Boolean _alphaBleed { get => _alphaBleed_Element.Data; set => _alphaBleed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _alphaBleed_Element = new();
public global::System.Boolean _lut { get => _lut_Element.Data; set => _lut_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _lut_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_projection", _projection_Element.ToLinkField(context));
members.Add("_layout", _layout_Element.ToLinkField(context));
members.Add("_screenshot", _screenshot_Element.ToLinkField(context));
members.Add("_pointFiltering", _pointFiltering_Element.ToLinkField(context));
members.Add("_uncompressed", _uncompressed_Element.ToLinkField(context));
members.Add("_alphaBleed", _alphaBleed_Element.ToLinkField(context));
members.Add("_lut", _lut_Element.ToLinkField(context));
}

}
}

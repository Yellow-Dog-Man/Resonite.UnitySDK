
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VideoImportDialog
// Generated on: čtvrtek 26. února 2026 15:09:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VideoImportDialog")]
public partial class VideoImportDialog : global::FrooxEngine.ImportDialog

{
    public global::FrooxEngine.VideoImportDialog.VideoType _videoType { get => _videoType_Element.Data; set => _videoType_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VideoImportDialog.VideoType>, global::FrooxEngine.VideoImportDialog.VideoType> _videoType_Element = new();
public global::Elements.Core.StereoLayout _stereoLayout { get => _stereoLayout_Element.Data; set => _stereoLayout_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Core.StereoLayout>, global::Elements.Core.StereoLayout> _stereoLayout_Element = new();
public global::FrooxEngine.VideoImportDialog.DepthPreset _depthPreset { get => _depthPreset_Element.Data; set => _depthPreset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VideoImportDialog.DepthPreset>, global::FrooxEngine.VideoImportDialog.DepthPreset> _depthPreset_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_videoType", _videoType_Element.ToLinkField(context));
members.Add("_stereoLayout", _stereoLayout_Element.ToLinkField(context));
members.Add("_depthPreset", _depthPreset_Element.ToLinkField(context));
}

}
}

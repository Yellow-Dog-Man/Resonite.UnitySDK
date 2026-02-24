
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VideoImportDialog
// Generated on: úterý 24. února 2026 18:20:30
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VideoImportDialog")]
public partial class VideoImportDialog : global::FrooxEngine.ImportDialog

{
    public global::FrooxEngine.VideoImportDialog.VideoType _videoType;
public global::Elements.Core.StereoLayout _stereoLayout;
public global::FrooxEngine.VideoImportDialog.DepthPreset _depthPreset;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_videoType", _videoType.ToResoniteLinkField());
members.Add("_stereoLayout", _stereoLayout.ToResoniteLinkField());
members.Add("_depthPreset", _depthPreset.ToResoniteLinkField());
}

}
}

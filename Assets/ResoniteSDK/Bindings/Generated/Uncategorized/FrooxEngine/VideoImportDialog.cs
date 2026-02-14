
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VideoImportDialog
// Generated on: sobota 14. února 2026 8:58:49
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DesktopStreamConfigDialog
// Generated on: pátek 14. srpna 2026 21:57:55
// Resonite version: 2026.8.12.1196
// Resonite Link Version: 0.13.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DesktopStreamConfigDialog")]
public partial class DesktopStreamConfigDialog : global::FrooxEngine.Component

{
    public global::System.Boolean DesktopAudio { get => DesktopAudio_Element.Data; set => DesktopAudio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DesktopAudio_Element = new();
public global::System.Int32 FPS { get => FPS_Element.Data; set => FPS_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> FPS_Element = new();
public global::System.Int32 VerticalResolution { get => VerticalResolution_Element.Data; set => VerticalResolution_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> VerticalResolution_Element = new();
public global::System.Single BitrateMbps { get => BitrateMbps_Element.Data; set => BitrateMbps_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> BitrateMbps_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DesktopAudio", DesktopAudio_Element.ToLinkField(context));
members.Add("FPS", FPS_Element.ToLinkField(context));
members.Add("VerticalResolution", VerticalResolution_Element.ToLinkField(context));
members.Add("BitrateMbps", BitrateMbps_Element.ToLinkField(context));
}

}
}

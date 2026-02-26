
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CameraPermissions
// Generated on: čtvrtek 26. února 2026 12:26:57
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CameraPermissions")]
public partial class CameraPermissions : global::FrooxEngine.PermissionsComponent

{
    public global::FrooxEngine.ListFilterMode CameraModeFilterMode { get => CameraModeFilterMode_Element.Data; set => CameraModeFilterMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ListFilterMode>, global::FrooxEngine.ListFilterMode> CameraModeFilterMode_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::FrooxEngine.CameraPositioningMode>, global::FrooxEngine.CameraPositioningMode, Field<global::FrooxEngine.Sync<global::FrooxEngine.CameraPositioningMode>, global::FrooxEngine.CameraPositioningMode>> CameraModes = new();
public global::System.Boolean AllowFramingOtherUsers { get => AllowFramingOtherUsers_Element.Data; set => AllowFramingOtherUsers_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowFramingOtherUsers_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CameraModeFilterMode", CameraModeFilterMode_Element.ToLinkField(context));
members.Add("CameraModes", CameraModes.ToLinkList(context, m => m.ToLinkField(context)));
members.Add("AllowFramingOtherUsers", AllowFramingOtherUsers_Element.ToLinkField(context));
}

}
}

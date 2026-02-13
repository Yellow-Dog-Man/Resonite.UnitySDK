
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CameraPermissions
// Generated on: pátek 13. února 2026 23:21:42
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CameraPermissions")]
public partial class CameraPermissions : global::FrooxEngine.PermissionsComponent

{
    public global::FrooxEngine.ListFilterMode CameraModeFilterMode;
public System.Collections.Generic.List<global::FrooxEngine.CameraPositioningMode> CameraModes;
public global::System.Boolean AllowFramingOtherUsers;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("CameraModeFilterMode", CameraModeFilterMode.ToResoniteLinkField());
members.Add("CameraModes", new ResoniteLink.SyncList()
{
    Elements = CameraModes.ConvertList(m => m.ToResoniteLinkField())
});
members.Add("AllowFramingOtherUsers", AllowFramingOtherUsers.ToResoniteLinkField());
}

}
}

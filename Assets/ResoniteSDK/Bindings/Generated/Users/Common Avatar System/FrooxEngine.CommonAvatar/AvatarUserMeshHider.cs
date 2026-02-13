
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarUserMeshHider
// Generated on: pátek 13. února 2026 23:23:19
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarUserMeshHider")]
public partial class AvatarUserMeshHider : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::FrooxEngine.CommonAvatar.AvatarUserMeshHider.HideMethod Method;
public System.Collections.Generic.List<global::FrooxEngine.MeshRenderer> Exclude;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Method", Method.ToResoniteLinkField());
members.Add("Exclude", new ResoniteLink.SyncList()
{
    Elements = Exclude.ConvertList(m => new ResoniteLink.Reference() { })
});
}

}
}

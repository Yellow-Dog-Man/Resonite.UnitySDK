
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarUserMeshHider
// Generated on: sobota 14. února 2026 8:58:49
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Method", Method.ToResoniteLinkField());
members.Add("Exclude", new ResoniteLink.SyncList()
{
    Elements = Exclude.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}

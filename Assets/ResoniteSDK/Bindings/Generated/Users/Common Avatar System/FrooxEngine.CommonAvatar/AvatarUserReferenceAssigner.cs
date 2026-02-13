
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarUserReferenceAssigner
// Generated on: pátek 13. února 2026 5:52:38
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarUserReferenceAssigner")]
public partial class AvatarUserReferenceAssigner : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::FrooxEngine.CommonAvatar.AvatarUserReferenceAssigner.Mode AssignMode;
public System.Collections.Generic.List<global::FrooxEngine.SyncRef<global::FrooxEngine.User>> References;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("AssignMode", AssignMode.ToResoniteLinkField());
members.Add("References", new ResoniteLink.SyncList()
{
    Elements = References.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
}

}
}

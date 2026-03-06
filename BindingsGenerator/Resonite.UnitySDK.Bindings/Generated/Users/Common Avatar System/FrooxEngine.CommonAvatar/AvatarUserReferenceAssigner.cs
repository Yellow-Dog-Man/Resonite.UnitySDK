
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarUserReferenceAssigner
// Generated on: pátek 6. března 2026 14:19:11
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public global::FrooxEngine.CommonAvatar.AvatarUserReferenceAssigner.Mode AssignMode { get => AssignMode_Element.Data; set => AssignMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.CommonAvatar.AvatarUserReferenceAssigner.Mode>, global::FrooxEngine.CommonAvatar.AvatarUserReferenceAssigner.Mode> AssignMode_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.SyncRef<global::FrooxEngine.User>>, global::FrooxEngine.SyncRef<global::FrooxEngine.User>, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncRef<global::FrooxEngine.User>>, global::FrooxEngine.SyncRef<global::FrooxEngine.User>>> References = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AssignMode", AssignMode_Element.ToLinkField(context));
members.Add("References", References.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}

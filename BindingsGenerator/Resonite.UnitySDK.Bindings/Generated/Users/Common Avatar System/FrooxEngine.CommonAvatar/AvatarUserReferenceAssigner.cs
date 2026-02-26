
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarUserReferenceAssigner
// Generated on: čtvrtek 26. února 2026 10:04:49
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.SyncRef<global::FrooxEngine.User>>, global::FrooxEngine.SyncRef<global::FrooxEngine.User>, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncRef<global::FrooxEngine.User>>, global::FrooxEngine.SyncRef<global::FrooxEngine.User>>> References = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AssignMode", AssignMode_Element.Data.ToResoniteLinkField());
members.Add("References", new ResoniteLink.SyncList()
{
    Elements = References.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
}

}
}

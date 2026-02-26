
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.EntityInterface
// Generated on: čtvrtek 26. února 2026 15:07:57
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.EntityInterface")]
public abstract partial class EntityInterface : global::FrooxEngine.Component, global::FrooxEngine.IItemMetadataSource

{
    public global::FrooxEngine.IField<global::System.String> ItemName { get => ItemName_Element.Data; set => ItemName_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> ItemName_Element = new();
public global::FrooxEngine.UserRef SpawningUser { get => SpawningUser_Element.Data; set => SpawningUser_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UserRef>, global::FrooxEngine.UserRef> SpawningUser_Element = new();
public global::FrooxEngine.IField<global::System.String> SpawningUserID { get => SpawningUserID_Element.Data; set => SpawningUserID_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> SpawningUserID_Element = new();
public global::System.Boolean IsInstance { get => IsInstance_Element.Data; set => IsInstance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsInstance_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ItemName", ItemName_Element.ToLinkReference(context));
members.Add("SpawningUser", SpawningUser_Element.ToLinkReference(context));
members.Add("SpawningUserID", SpawningUserID_Element.ToLinkReference(context));
members.Add("IsInstance", IsInstance_Element.ToLinkField(context));
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarNameTagAssigner
// Generated on: čtvrtek 26. února 2026 15:09:17
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.CommonAvatar
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarNameTagAssigner")]
public partial class AvatarNameTagAssigner : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>>> LabelTargets = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>>> UserIdTargets = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.IField<UnityEngine.ColorX>>, global::FrooxEngine.IField<UnityEngine.ColorX>, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.ColorX>>, global::FrooxEngine.IField<UnityEngine.ColorX>>> ColorTargets = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.IField<UnityEngine.ColorX>>, global::FrooxEngine.IField<UnityEngine.ColorX>, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.ColorX>>, global::FrooxEngine.IField<UnityEngine.ColorX>>> OutlineTargets = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.IField<UnityEngine.ColorX>>, global::FrooxEngine.IField<UnityEngine.ColorX>, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.ColorX>>, global::FrooxEngine.IField<UnityEngine.ColorX>>> BackgroundTargets = new();
public global::System.String DequippedLabel { get => DequippedLabel_Element.Data; set => DequippedLabel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> DequippedLabel_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LabelTargets", LabelTargets.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("UserIdTargets", UserIdTargets.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("ColorTargets", ColorTargets.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("OutlineTargets", OutlineTargets.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("BackgroundTargets", BackgroundTargets.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("DequippedLabel", DequippedLabel_Element.ToLinkField(context));
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarNameTagAssigner
// Generated on: čtvrtek 26. února 2026 10:04:50
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarNameTagAssigner")]
public partial class AvatarNameTagAssigner : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>>> LabelTargets = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>>> UserIdTargets = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.IField<UnityEngine.ColorX>>, global::FrooxEngine.IField<UnityEngine.ColorX>, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.ColorX>>, global::FrooxEngine.IField<UnityEngine.ColorX>>> ColorTargets = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.IField<UnityEngine.ColorX>>, global::FrooxEngine.IField<UnityEngine.ColorX>, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.ColorX>>, global::FrooxEngine.IField<UnityEngine.ColorX>>> OutlineTargets = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.IField<UnityEngine.ColorX>>, global::FrooxEngine.IField<UnityEngine.ColorX>, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.ColorX>>, global::FrooxEngine.IField<UnityEngine.ColorX>>> BackgroundTargets = new();
public global::System.String DequippedLabel { get => DequippedLabel_Element.Data; set => DequippedLabel_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> DequippedLabel_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("LabelTargets", new ResoniteLink.SyncList()
{
    Elements = LabelTargets.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("UserIdTargets", new ResoniteLink.SyncList()
{
    Elements = UserIdTargets.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("ColorTargets", new ResoniteLink.SyncList()
{
    Elements = ColorTargets.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("OutlineTargets", new ResoniteLink.SyncList()
{
    Elements = OutlineTargets.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("BackgroundTargets", new ResoniteLink.SyncList()
{
    Elements = BackgroundTargets.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("DequippedLabel", DequippedLabel_Element.Data.ToResoniteLinkField());
}

}
}

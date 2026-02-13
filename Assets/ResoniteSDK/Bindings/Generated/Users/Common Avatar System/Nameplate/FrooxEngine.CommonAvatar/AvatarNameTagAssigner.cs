
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CommonAvatar.AvatarNameTagAssigner
// Generated on: pátek 13. února 2026 5:52:39
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CommonAvatar.AvatarNameTagAssigner")]
public partial class AvatarNameTagAssigner : global::FrooxEngine.Component, global::FrooxEngine.CommonAvatar.IAvatarObjectComponent

{
    public System.Collections.Generic.List<global::FrooxEngine.IField<global::System.String>> LabelTargets;
public System.Collections.Generic.List<global::FrooxEngine.IField<global::System.String>> UserIdTargets;
public System.Collections.Generic.List<global::FrooxEngine.IField<UnityEngine.ColorX>> ColorTargets;
public System.Collections.Generic.List<global::FrooxEngine.IField<UnityEngine.ColorX>> OutlineTargets;
public System.Collections.Generic.List<global::FrooxEngine.IField<UnityEngine.ColorX>> BackgroundTargets;
public global::System.String DequippedLabel;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("LabelTargets", new ResoniteLink.SyncList()
{
    Elements = LabelTargets.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("UserIdTargets", new ResoniteLink.SyncList()
{
    Elements = UserIdTargets.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("ColorTargets", new ResoniteLink.SyncList()
{
    Elements = ColorTargets.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("OutlineTargets", new ResoniteLink.SyncList()
{
    Elements = OutlineTargets.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("BackgroundTargets", new ResoniteLink.SyncList()
{
    Elements = BackgroundTargets.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
members.Add("DequippedLabel", DequippedLabel.ToResoniteLinkField());
}

}
}

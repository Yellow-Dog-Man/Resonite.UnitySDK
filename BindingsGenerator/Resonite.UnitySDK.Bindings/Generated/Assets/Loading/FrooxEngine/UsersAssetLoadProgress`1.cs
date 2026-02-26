
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UsersAssetLoadProgress<>
// Generated on: čtvrtek 26. února 2026 10:03:33
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UsersAssetLoadProgress<>")]
public partial class UsersAssetLoadProgress<A> : global::FrooxEngine.Component
	where A : class, global::FrooxEngine.IAsset

{
    public global::FrooxEngine.IAssetProvider<A> Asset { get => Asset_Element.Data; set => Asset_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<A>, global::FrooxEngine.IAssetProvider<A>> Asset_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.UsersAssetLoadProgress<A>.LoadProgress>, global::FrooxEngine.UsersAssetLoadProgress<A>.LoadProgress> ProgressInfo = new();
public global::System.Int32 TotalUsers { get => TotalUsers_Element.Data; set => TotalUsers_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> TotalUsers_Element = new();
public global::System.Int32 UsersNotLoaded { get => UsersNotLoaded_Element.Data; set => UsersNotLoaded_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> UsersNotLoaded_Element = new();
public global::System.Int32 UsersLoading { get => UsersLoading_Element.Data; set => UsersLoading_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> UsersLoading_Element = new();
public global::System.Int32 UsersPartiallyLoaded { get => UsersPartiallyLoaded_Element.Data; set => UsersPartiallyLoaded_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> UsersPartiallyLoaded_Element = new();
public global::System.Int32 UsersFullyLoaded { get => UsersFullyLoaded_Element.Data; set => UsersFullyLoaded_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> UsersFullyLoaded_Element = new();
public global::System.Int32 UsersFailedToLoad { get => UsersFailedToLoad_Element.Data; set => UsersFailedToLoad_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Int32>, global::System.Int32> UsersFailedToLoad_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Asset", Asset_Element.Data.ToResoniteReference(context));
members.Add("ProgressInfo", new ResoniteLink.SyncList()
{
    Elements = ProgressInfo.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("TotalUsers", TotalUsers_Element.Data.ToResoniteLinkField());
members.Add("UsersNotLoaded", UsersNotLoaded_Element.Data.ToResoniteLinkField());
members.Add("UsersLoading", UsersLoading_Element.Data.ToResoniteLinkField());
members.Add("UsersPartiallyLoaded", UsersPartiallyLoaded_Element.Data.ToResoniteLinkField());
members.Add("UsersFullyLoaded", UsersFullyLoaded_Element.Data.ToResoniteLinkField());
members.Add("UsersFailedToLoad", UsersFailedToLoad_Element.Data.ToResoniteLinkField());
}

}
}

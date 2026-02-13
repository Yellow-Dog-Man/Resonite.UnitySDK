
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SetDataFeedCategory
// Generated on: pátek 13. února 2026 5:52:18
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SetDataFeedCategory")]
public partial class SetDataFeedCategory : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::FrooxEngine.IDataFeedView View;
public System.Collections.Generic.List<global::System.String> CategoryPath;
public global::System.Boolean IsInsideCategoryPath;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("View", new ResoniteLink.Reference() { });
members.Add("CategoryPath", new ResoniteLink.SyncList()
{
    Elements = CategoryPath.Select(m => m.ToResoniteLinkField()).ToList<ResoniteLink.Member>()
});
members.Add("IsInsideCategoryPath", IsInsideCategoryPath.ToResoniteLinkField());
}

}
}

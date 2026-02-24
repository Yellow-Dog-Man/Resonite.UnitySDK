
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SetDataFeedCategory
// Generated on: úterý 24. února 2026 18:20:02
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("View", View.ToResoniteReference(context));
members.Add("CategoryPath", new ResoniteLink.SyncList()
{
    Elements = CategoryPath.ConvertList(m => m.ToResoniteLinkField())
});
members.Add("IsInsideCategoryPath", IsInsideCategoryPath.ToResoniteLinkField());
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacySegmentCircleMenuController+ItemsArc
// Generated on: čtvrtek 26. února 2026 10:04:39
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
    public partial class LegacySegmentCircleMenuController
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacySegmentCircleMenuController+ItemsArc")]
public partial class ItemsArc : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.LegacySegmentCircleMenuController.Item CenterItem { get => CenterItem_Element.Data; set => CenterItem_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.LegacySegmentCircleMenuController.Item>, global::FrooxEngine.LegacySegmentCircleMenuController.Item> CenterItem_Element = new();
public global::System.Single SeparationAngle { get => SeparationAngle_Element.Data; set => SeparationAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SeparationAngle_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.LegacySegmentCircleMenuController.ItemsArc.ArcItem>, global::FrooxEngine.LegacySegmentCircleMenuController.ItemsArc.ArcItem> _left = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.LegacySegmentCircleMenuController.ItemsArc.ArcItem>, global::FrooxEngine.LegacySegmentCircleMenuController.ItemsArc.ArcItem> _right = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CenterItem", CenterItem_Element.Data.ToResoniteReference(context));
members.Add("SeparationAngle", SeparationAngle_Element.Data.ToResoniteLinkField());
members.Add("_left", new ResoniteLink.SyncList()
{
    Elements = _left.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("_right", new ResoniteLink.SyncList()
{
    Elements = _right.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
            }
}

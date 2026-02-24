
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ObjectGridAligner
// Generated on: úterý 24. února 2026 18:20:14
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ObjectGridAligner")]
public partial class ObjectGridAligner : global::FrooxEngine.AutoAddChildrenBase

{
    public global::System.Int32 ItemsPerRow;
public UnityEngine.Vector2 CellSize;
public global::System.Single LerpSpeed;
public global::FrooxEngine.ObjectGridAligner.Align HorizontalAlignment;
public global::FrooxEngine.ObjectGridAligner.Align VerticalAlignment;
public global::FrooxEngine.ObjectGridAligner.AxisDir RowAxis;
public global::FrooxEngine.ObjectGridAligner.AxisDir ColumnAxis;
public System.Collections.Generic.List<global::FrooxEngine.ObjectGridAligner.Item> Items;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ItemsPerRow", ItemsPerRow.ToResoniteLinkField());
members.Add("CellSize", CellSize.ToResoniteLinkField());
members.Add("LerpSpeed", LerpSpeed.ToResoniteLinkField());
members.Add("HorizontalAlignment", HorizontalAlignment.ToResoniteLinkField());
members.Add("VerticalAlignment", VerticalAlignment.ToResoniteLinkField());
members.Add("RowAxis", RowAxis.ToResoniteLinkField());
members.Add("ColumnAxis", ColumnAxis.ToResoniteLinkField());
members.Add("Items", new ResoniteLink.SyncList()
{
    Elements = Items.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
}

}
}

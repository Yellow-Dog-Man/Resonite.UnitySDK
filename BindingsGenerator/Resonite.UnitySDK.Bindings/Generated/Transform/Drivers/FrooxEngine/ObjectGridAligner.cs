
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ObjectGridAligner
// Generated on: čtvrtek 26. února 2026 12:28:07
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ObjectGridAligner")]
public partial class ObjectGridAligner : global::FrooxEngine.AutoAddChildrenBase

{
    public global::System.Int32 ItemsPerRow { get => ItemsPerRow_Element.Data; set => ItemsPerRow_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> ItemsPerRow_Element = new();
public UnityEngine.Vector2 CellSize { get => CellSize_Element.Data; set => CellSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector2>, UnityEngine.Vector2> CellSize_Element = new();
public global::System.Single LerpSpeed { get => LerpSpeed_Element.Data; set => LerpSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> LerpSpeed_Element = new();
public global::FrooxEngine.ObjectGridAligner.Align HorizontalAlignment { get => HorizontalAlignment_Element.Data; set => HorizontalAlignment_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ObjectGridAligner.Align>, global::FrooxEngine.ObjectGridAligner.Align> HorizontalAlignment_Element = new();
public global::FrooxEngine.ObjectGridAligner.Align VerticalAlignment { get => VerticalAlignment_Element.Data; set => VerticalAlignment_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ObjectGridAligner.Align>, global::FrooxEngine.ObjectGridAligner.Align> VerticalAlignment_Element = new();
public global::FrooxEngine.ObjectGridAligner.AxisDir RowAxis { get => RowAxis_Element.Data; set => RowAxis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ObjectGridAligner.AxisDir>, global::FrooxEngine.ObjectGridAligner.AxisDir> RowAxis_Element = new();
public global::FrooxEngine.ObjectGridAligner.AxisDir ColumnAxis { get => ColumnAxis_Element.Data; set => ColumnAxis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.ObjectGridAligner.AxisDir>, global::FrooxEngine.ObjectGridAligner.AxisDir> ColumnAxis_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.ObjectGridAligner.Item>, global::FrooxEngine.ObjectGridAligner.Item> Items = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ItemsPerRow", ItemsPerRow_Element.ToLinkField(context));
members.Add("CellSize", CellSize_Element.ToLinkField(context));
members.Add("LerpSpeed", LerpSpeed_Element.ToLinkField(context));
members.Add("HorizontalAlignment", HorizontalAlignment_Element.ToLinkField(context));
members.Add("VerticalAlignment", VerticalAlignment_Element.ToLinkField(context));
members.Add("RowAxis", RowAxis_Element.ToLinkField(context));
members.Add("ColumnAxis", ColumnAxis_Element.ToLinkField(context));
members.Add("Items", Items.ToLinkList(context, m => m.ToLinkSyncObject(context)));
}

}
}

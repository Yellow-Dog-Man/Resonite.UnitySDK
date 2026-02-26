
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ObjectSlicerTool
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ObjectSlicerTool")]
public partial class ObjectSlicerTool : global::FrooxEngine.BuilderActionTool

{
    public UnityEngine.ColorX EdgeColor { get => EdgeColor_Element.Data; set => EdgeColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> EdgeColor_Element = new();
public global::System.Single EdgeStart { get => EdgeStart_Element.Data; set => EdgeStart_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EdgeStart_Element = new();
public global::System.Single EdgeEnd { get => EdgeEnd_Element.Data; set => EdgeEnd_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> EdgeEnd_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.GenericSlicer>, global::FrooxEngine.GenericSlicer, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.GenericSlicer>, global::FrooxEngine.GenericSlicer>> _slicers = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.PBS_Slice>, global::FrooxEngine.PBS_Slice, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.PBS_Slice>, global::FrooxEngine.PBS_Slice>> _sliceMaterials = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EdgeColor", EdgeColor_Element.Data.ToResoniteLinkField());
members.Add("EdgeStart", EdgeStart_Element.Data.ToResoniteLinkField());
members.Add("EdgeEnd", EdgeEnd_Element.Data.ToResoniteLinkField());
members.Add("_slicers", new ResoniteLink.SyncList()
{
    Elements = _slicers.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
members.Add("_sliceMaterials", new ResoniteLink.SyncList()
{
    Elements = _sliceMaterials.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
}

}
}

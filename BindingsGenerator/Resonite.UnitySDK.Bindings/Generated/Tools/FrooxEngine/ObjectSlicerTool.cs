
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ObjectSlicerTool
// Generated on: čtvrtek 26. února 2026 15:09:06
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.GenericSlicer>, global::FrooxEngine.GenericSlicer, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.GenericSlicer>, global::FrooxEngine.GenericSlicer>> _slicers = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.PBS_Slice>, global::FrooxEngine.PBS_Slice, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.PBS_Slice>, global::FrooxEngine.PBS_Slice>> _sliceMaterials = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EdgeColor", EdgeColor_Element.ToLinkField(context));
members.Add("EdgeStart", EdgeStart_Element.ToLinkField(context));
members.Add("EdgeEnd", EdgeEnd_Element.ToLinkField(context));
members.Add("_slicers", _slicers.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("_sliceMaterials", _sliceMaterials.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}

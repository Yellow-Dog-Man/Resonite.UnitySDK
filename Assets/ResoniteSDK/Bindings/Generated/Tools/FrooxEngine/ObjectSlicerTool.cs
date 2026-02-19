
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ObjectSlicerTool
// Generated on: čtvrtek 19. února 2026 8:00:22
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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
    public UnityEngine.ColorX EdgeColor;
public global::System.Single EdgeStart;
public global::System.Single EdgeEnd;
public System.Collections.Generic.List<global::FrooxEngine.GenericSlicer> _slicers;
public System.Collections.Generic.List<global::FrooxEngine.PBS_Slice> _sliceMaterials;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EdgeColor", EdgeColor.ToResoniteLinkField());
members.Add("EdgeStart", EdgeStart.ToResoniteLinkField());
members.Add("EdgeEnd", EdgeEnd.ToResoniteLinkField());
members.Add("_slicers", new ResoniteLink.SyncList()
{
    Elements = _slicers.ConvertList(m => m.ToResoniteReference(context))
});
members.Add("_sliceMaterials", new ResoniteLink.SyncList()
{
    Elements = _sliceMaterials.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}

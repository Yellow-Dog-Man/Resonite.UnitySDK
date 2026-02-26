
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ToolMultiplexer
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ToolMultiplexer")]
public partial class ToolMultiplexer : global::FrooxEngine.Tool

{
    public global::System.Int32 ActiveToolIndex { get => ActiveToolIndex_Element.Data; set => ActiveToolIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> ActiveToolIndex_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.ITool>, global::FrooxEngine.ITool, Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ITool>, global::FrooxEngine.ITool>> Tools = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ActiveToolIndex", ActiveToolIndex_Element.Data.ToResoniteLinkField());
members.Add("Tools", new ResoniteLink.SyncList()
{
    Elements = Tools.Data.ConvertList(m => m.Data.ToResoniteReference(context))
});
}

}
}

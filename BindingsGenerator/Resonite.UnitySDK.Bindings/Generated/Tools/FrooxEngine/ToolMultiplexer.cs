
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ToolMultiplexer
// Generated on: pátek 6. března 2026 14:19:05
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.ITool>, global::FrooxEngine.ITool, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.ITool>, global::FrooxEngine.ITool>> Tools = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ActiveToolIndex", ActiveToolIndex_Element.ToLinkField(context));
members.Add("Tools", Tools.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}

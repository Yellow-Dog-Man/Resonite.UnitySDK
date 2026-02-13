
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ToolMultiplexer
// Generated on: pátek 13. února 2026 23:23:08
// Resonite version: 2026.2.12.359
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ToolMultiplexer")]
public partial class ToolMultiplexer : global::FrooxEngine.Tool

{
    public global::System.Int32 ActiveToolIndex;
public System.Collections.Generic.List<global::FrooxEngine.ITool> Tools;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ActiveToolIndex", ActiveToolIndex.ToResoniteLinkField());
members.Add("Tools", new ResoniteLink.SyncList()
{
    Elements = Tools.ConvertList(m => new ResoniteLink.Reference() { })
});
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ObjectScroller
// Generated on: pátek 13. února 2026 23:23:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ObjectScroller")]
public partial class ObjectScroller : global::FrooxEngine.Component

{
    public System.Collections.Generic.List<global::FrooxEngine.ObjectScroller.Item> Items;
public UnityEngine.Vector3 Offset;
public UnityEngine.Vector3 RegionSize;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Items", new ResoniteLink.SyncList()
{
    Elements = Items.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
members.Add("Offset", Offset.ToResoniteLinkField());
members.Add("RegionSize", RegionSize.ToResoniteLinkField());
}

}
}

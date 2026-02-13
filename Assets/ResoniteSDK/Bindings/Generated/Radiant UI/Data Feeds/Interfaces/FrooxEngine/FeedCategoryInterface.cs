
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedCategoryInterface
// Generated on: pátek 13. února 2026 23:23:01
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FeedCategoryInterface")]
public partial class FeedCategoryInterface : global::FrooxEngine.FeedItemInterface

{
    public global::FrooxEngine.SyncFieldList<global::System.String> Path;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Path", new ResoniteLink.Reference() { });
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FeedCategoryInterface
// Generated on: pondělí 2. března 2026 17:53:26
// Resonite version: 2026.3.2.1000
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FeedCategoryInterface")]
public partial class FeedCategoryInterface : global::FrooxEngine.FeedItemInterface

{
    public global::FrooxEngine.SyncFieldList<global::System.String> Path { get => Path_Element.Data; set => Path_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncFieldList<global::System.String>>, global::FrooxEngine.SyncFieldList<global::System.String>> Path_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Path", Path_Element.ToLinkReference(context));
}

}
}

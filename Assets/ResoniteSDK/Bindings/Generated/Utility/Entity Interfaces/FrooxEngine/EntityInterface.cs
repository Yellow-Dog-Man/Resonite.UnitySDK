
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.EntityInterface
// Generated on: pátek 13. února 2026 23:21:38
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.EntityInterface")]
public abstract partial class EntityInterface : global::FrooxEngine.Component, global::FrooxEngine.IItemMetadataSource

{
    public global::FrooxEngine.IField<global::System.String> ItemName;
public global::FrooxEngine.UserRef SpawningUser;
public global::FrooxEngine.IField<global::System.String> SpawningUserID;
public global::System.Boolean IsInstance;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("ItemName", new ResoniteLink.Reference() { });
members.Add("SpawningUser", new ResoniteLink.Reference() { });
members.Add("SpawningUserID", new ResoniteLink.Reference() { });
members.Add("IsInstance", IsInstance.ToResoniteLinkField());
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.EntityInterface
// Generated on: úterý 24. února 2026 18:17:45
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ItemName", ItemName.ToResoniteReference(context));
members.Add("SpawningUser", SpawningUser.ToResoniteReference(context));
members.Add("SpawningUserID", SpawningUserID.ToResoniteReference(context));
members.Add("IsInstance", IsInstance.ToResoniteLinkField());
}

}
}

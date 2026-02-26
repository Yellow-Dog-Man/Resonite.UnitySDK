
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SubmeshCharacterControllerModifier
// Generated on: čtvrtek 26. února 2026 10:03:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SubmeshCharacterControllerModifier")]
public partial class SubmeshCharacterControllerModifier : global::FrooxEngine.MeshColliderCharacterControllerModifier

{
    public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::System.Single>, global::System.Single, Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single>> Values = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Values", new ResoniteLink.SyncList()
{
    Elements = Values.Data.ConvertList(m => m.Data.ToResoniteLinkField())
});
}

}
}

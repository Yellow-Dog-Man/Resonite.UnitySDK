
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SubmeshCharacterControllerModifier
// Generated on: čtvrtek 19. února 2026 7:58:59
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SubmeshCharacterControllerModifier")]
public partial class SubmeshCharacterControllerModifier : global::FrooxEngine.MeshColliderCharacterControllerModifier

{
    public System.Collections.Generic.List<global::System.Single> Values;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Values", new ResoniteLink.SyncList()
{
    Elements = Values.ConvertList(m => m.ToResoniteLinkField())
});
}

}
}

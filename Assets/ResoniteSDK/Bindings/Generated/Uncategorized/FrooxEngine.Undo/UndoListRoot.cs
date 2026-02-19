
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Undo.UndoListRoot
// Generated on: čtvrtek 19. února 2026 8:00:31
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.Undo
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Undo.UndoListRoot")]
public partial class UndoListRoot : global::FrooxEngine.Component

{
    public global::FrooxEngine.UserRef OwnerUser;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OwnerUser", new ResoniteLink.SyncObject() { Members = OwnerUser.CollectMembers(context) });
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GenericUIContainer
// Generated on: čtvrtek 19. února 2026 7:58:55
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GenericUIContainer")]
public partial class GenericUIContainer : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.String> Title;
public global::System.Boolean CloseRequest;
public global::FrooxEngine.Slot CloseDestroyRoot;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Title", Title.ToResoniteReference(context));
members.Add("CloseRequest", CloseRequest.ToResoniteLinkField());
members.Add("CloseDestroyRoot", CloseDestroyRoot.ToResoniteReference(context));
}

}
}

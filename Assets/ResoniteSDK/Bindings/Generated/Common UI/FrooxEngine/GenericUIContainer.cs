
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GenericUIContainer
// Generated on: pátek 13. února 2026 23:21:37
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GenericUIContainer")]
public partial class GenericUIContainer : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.String> Title;
public global::System.Boolean CloseRequest;
public global::FrooxEngine.Slot CloseDestroyRoot;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Title", new ResoniteLink.Reference() { });
members.Add("CloseRequest", CloseRequest.ToResoniteLinkField());
members.Add("CloseDestroyRoot", new ResoniteLink.Reference() { });
}

}
}

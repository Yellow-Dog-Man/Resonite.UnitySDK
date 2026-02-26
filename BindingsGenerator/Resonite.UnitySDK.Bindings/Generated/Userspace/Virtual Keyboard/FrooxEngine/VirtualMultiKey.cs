
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VirtualMultiKey
// Generated on: čtvrtek 26. února 2026 15:09:17
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VirtualMultiKey")]
public partial class VirtualMultiKey : global::FrooxEngine.VirtualKeyBase, global::FrooxEngine.IButtonPressReceiver

{
    public global::SyncFieldList<global::FrooxEngine.SyncFieldList<global::Renderite.Shared.Key>, global::Renderite.Shared.Key, Field<global::FrooxEngine.Sync<global::Renderite.Shared.Key>, global::Renderite.Shared.Key>> Keys = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Keys", Keys.ToLinkList(context, m => m.ToLinkField(context)));
}

}
}

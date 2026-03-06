
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VirtualMultiKey
// Generated on: pátek 6. března 2026 14:19:12
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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

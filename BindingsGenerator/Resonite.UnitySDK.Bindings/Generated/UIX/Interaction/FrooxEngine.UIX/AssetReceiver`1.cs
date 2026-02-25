
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.AssetReceiver<>
// Generated on: středa 25. února 2026 16:14:33
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.AssetReceiver<>")]
public partial class AssetReceiver<A> : global::FrooxEngine.Component, global::FrooxEngine.UIX.IUIGrabReceiver
	where A : class, global::FrooxEngine.IAsset

{
    public global::FrooxEngine.AssetRef<A> Reference;
public global::System.Boolean Undoable;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Reference", Reference.ToResoniteReference(context));
members.Add("Undoable", Undoable.ToResoniteLinkField());
}

}
}

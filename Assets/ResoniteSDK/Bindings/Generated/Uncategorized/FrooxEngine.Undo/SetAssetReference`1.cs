
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Undo.SetAssetReference<>
// Generated on: pátek 13. února 2026 23:23:18
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.Undo
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Undo.SetAssetReference<>")]
public partial class SetAssetReference<A> : global::FrooxEngine.Component, global::FrooxEngine.Undo.IUndoable
	where A : class, global::FrooxEngine.IAsset

{
    public global::FrooxEngine.AssetRef<A> Target;
public global::FrooxEngine.IAssetProvider<A> TargetBefore;
public global::FrooxEngine.IAssetProvider<A> TargetAfter;
public global::System.Boolean _performed;
public global::System.String _description;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("TargetBefore", new ResoniteLink.Reference() { });
members.Add("TargetAfter", new ResoniteLink.Reference() { });
members.Add("_performed", _performed.ToResoniteLinkField());
members.Add("_description", _description.ToResoniteLinkField());
}

}
}

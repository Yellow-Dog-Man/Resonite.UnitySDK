
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Undo.SetAssetReference<>
// Generated on: sobota 14. února 2026 8:58:47
// Resonite version: 2026.2.14.493
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target.ToResoniteReference(context));
members.Add("TargetBefore", TargetBefore.ToResoniteReference(context));
members.Add("TargetAfter", TargetAfter.ToResoniteReference(context));
members.Add("_performed", _performed.ToResoniteLinkField());
members.Add("_description", _description.ToResoniteLinkField());
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonReferenceCycle<>
// Generated on: pátek 6. března 2026 14:18:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonReferenceCycle<>")]
public partial class ButtonReferenceCycle<T> : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver
	where T : class, global::FrooxEngine.IWorldElement

{
    public global::FrooxEngine.SyncRef<T> TargetReference { get => TargetReference_Element.Data; set => TargetReference_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncRef<T>>, global::FrooxEngine.SyncRef<T>> TargetReference_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<T>, T, Reference<global::FrooxEngine.SyncRef<T>, T>> Targets = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetReference", TargetReference_Element.ToLinkReference(context));
members.Add("Targets", Targets.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxDynamicElementManager
// Generated on: sobota 14. února 2026 8:58:47
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxDynamicElementManager")]
public abstract partial class ProtoFluxDynamicElementManager : global::FrooxEngine.Component

{
    public global::FrooxEngine.ProtoFlux.ProtoFluxNodeVisual Visual;
public global::FrooxEngine.ISyncList List;
public global::System.Int32 MinElements;
public global::FrooxEngine.IField<global::System.Boolean> AddButtonEnabled;
public global::FrooxEngine.IField<global::System.Boolean> RemoveButtonEnabled;
public System.Collections.Generic.List<global::FrooxEngine.Slot> _elements;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Visual", Visual.ToResoniteReference(context));
members.Add("List", List.ToResoniteReference(context));
members.Add("MinElements", MinElements.ToResoniteLinkField());
members.Add("AddButtonEnabled", AddButtonEnabled.ToResoniteReference(context));
members.Add("RemoveButtonEnabled", RemoveButtonEnabled.ToResoniteReference(context));
members.Add("_elements", new ResoniteLink.SyncList()
{
    Elements = _elements.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}

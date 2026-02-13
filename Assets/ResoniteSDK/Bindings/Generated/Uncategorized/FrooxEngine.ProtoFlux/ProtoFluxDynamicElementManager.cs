
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxDynamicElementManager
// Generated on: pátek 13. února 2026 23:23:17
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Visual", new ResoniteLink.Reference() { });
members.Add("List", new ResoniteLink.Reference() { });
members.Add("MinElements", MinElements.ToResoniteLinkField());
members.Add("AddButtonEnabled", new ResoniteLink.Reference() { });
members.Add("RemoveButtonEnabled", new ResoniteLink.Reference() { });
members.Add("_elements", new ResoniteLink.SyncList()
{
    Elements = _elements.ConvertList(m => new ResoniteLink.Reference() { })
});
}

}
}

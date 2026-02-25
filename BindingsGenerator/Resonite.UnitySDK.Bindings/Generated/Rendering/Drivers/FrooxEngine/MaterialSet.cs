
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MaterialSet
// Generated on: středa 25. února 2026 16:14:17
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MaterialSet")]
public partial class MaterialSet : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public global::System.Int32 ActiveSetIndex;
public global::FrooxEngine.SyncAssetList<global::FrooxEngine.Material> Target;
public System.Collections.Generic.List<System.Collections.Generic.List<global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>>> Sets;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ActiveSetIndex", ActiveSetIndex.ToResoniteLinkField());
members.Add("Target", Target.ToResoniteReference(context));
members.Add("Sets", new ResoniteLink.SyncList()
{
    Elements = Sets.ConvertList(m => new ResoniteLink.SyncList()
{
    Elements = m.ConvertList(m => m.ToResoniteReference(context))
})
});
}

}
}

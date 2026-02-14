
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MaterialSet
// Generated on: sobota 14. února 2026 8:58:34
// Resonite version: 2026.2.14.493
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

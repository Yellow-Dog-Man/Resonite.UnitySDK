
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SavedReferenceTable
// Generated on: pondělí 2. března 2026 17:53:32
// Resonite version: 2026.3.2.1000
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SavedReferenceTable")]
public partial class SavedReferenceTable : global::FrooxEngine.Component

{
    public global::SyncDictionary<global::FrooxEngine.SyncRefDictionary<global::System.String,global::FrooxEngine.IWorldElement>, global::System.String, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IWorldElement>, global::FrooxEngine.IWorldElement>> Table = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Table", Table.ToLinkDictionary(context, m => m.ToLinkReference(context)));
}

}
}

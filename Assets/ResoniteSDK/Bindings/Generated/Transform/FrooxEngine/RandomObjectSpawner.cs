
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RandomObjectSpawner
// Generated on: pátek 13. února 2026 5:52:25
// Resonite version: 2026.2.13.254
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RandomObjectSpawner")]
public partial class RandomObjectSpawner : global::FrooxEngine.Component

{
    public System.Collections.Generic.List<global::FrooxEngine.RandomObjectSpawner.SpawnData> Templates;
public global::FrooxEngine.RootSpace SpawnSpace;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Templates", new ResoniteLink.SyncList()
{
    Elements = Templates.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
members.Add("SpawnSpace", new ResoniteLink.SyncObject() { Members = SpawnSpace.CollectMembers() });
}

}
}

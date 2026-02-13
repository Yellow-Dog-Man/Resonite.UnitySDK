
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RandomObjectSpawner
// Generated on: pátek 13. února 2026 23:23:08
// Resonite version: 2026.2.12.359
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
    Elements = Templates.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() })
});
members.Add("SpawnSpace", new ResoniteLink.SyncObject() { Members = SpawnSpace.CollectMembers() });
}

}
}

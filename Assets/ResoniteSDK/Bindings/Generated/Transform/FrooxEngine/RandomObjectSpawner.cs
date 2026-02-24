
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RandomObjectSpawner
// Generated on: úterý 24. února 2026 18:20:13
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Templates", new ResoniteLink.SyncList()
{
    Elements = Templates.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("SpawnSpace", new ResoniteLink.SyncObject() { Members = SpawnSpace.CollectMembers(context) });
}

}
}

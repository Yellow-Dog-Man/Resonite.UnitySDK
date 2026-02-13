
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BinaryExportable
// Generated on: pátek 13. února 2026 23:21:32
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BinaryExportable")]
public partial class BinaryExportable : global::FrooxEngine.Component, global::FrooxEngine.IExportable

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Binary> Binary;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Binary", new ResoniteLink.Reference() { });
}

}
}

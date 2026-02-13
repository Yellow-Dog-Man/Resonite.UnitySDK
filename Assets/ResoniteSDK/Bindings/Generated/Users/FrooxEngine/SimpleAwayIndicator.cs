
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SimpleAwayIndicator
// Generated on: pátek 13. února 2026 23:23:19
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SimpleAwayIndicator")]
public partial class SimpleAwayIndicator : global::FrooxEngine.Component, global::FrooxEngine.IMeshBakeEventReceiver, global::FrooxEngine.ICustomInspector

{
    public global::FrooxEngine.User User;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material> AwayMaterial;
public global::FrooxEngine.MeshRenderer Renderer;
public System.Collections.Generic.List<global::FrooxEngine.IAssetProvider<global::FrooxEngine.Material>> _oldMaterials;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("User", new ResoniteLink.Reference() { });
members.Add("AwayMaterial", new ResoniteLink.Reference() { });
members.Add("Renderer", new ResoniteLink.Reference() { });
members.Add("_oldMaterials", new ResoniteLink.SyncList()
{
    Elements = _oldMaterials.ConvertList(m => new ResoniteLink.Reference() { })
});
}

}
}

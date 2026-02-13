
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextureExportable
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextureExportable")]
public partial class TextureExportable : global::FrooxEngine.Component, global::FrooxEngine.IExportable

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.Texture2D> Texture;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Texture", new ResoniteLink.Reference() { });
}

}
}

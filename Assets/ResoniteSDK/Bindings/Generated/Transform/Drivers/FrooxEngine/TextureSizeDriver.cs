
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextureSizeDriver
// Generated on: pátek 13. února 2026 5:52:26
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextureSizeDriver")]
public partial class TextureSizeDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Texture;
public global::FrooxEngine.IField<UnityEngine.Vector2> Target;
public global::FrooxEngine.TextureSizeDriver.Mode DriveMode;
public UnityEngine.Vector2 Premultiply;
public UnityEngine.Vector2 Ratio;
public UnityEngine.Vector2 MaxSize;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Texture", new ResoniteLink.Reference() { });
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("DriveMode", DriveMode.ToResoniteLinkField());
members.Add("Premultiply", Premultiply.ToResoniteLinkField());
members.Add("Ratio", Ratio.ToResoniteLinkField());
members.Add("MaxSize", MaxSize.ToResoniteLinkField());
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TextureSizeDriver
// Generated on: úterý 24. února 2026 18:20:15
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TextureSizeDriver")]
public partial class TextureSizeDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture2D> Texture;
public global::FrooxEngine.IField<UnityEngine.Vector2> Target;
public global::FrooxEngine.TextureSizeDriver.Mode DriveMode;
public UnityEngine.Vector2 Premultiply;
public UnityEngine.Vector2 Ratio;
public UnityEngine.Vector2 MaxSize;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Texture", Texture.ToResoniteReference(context));
members.Add("Target", Target.ToResoniteReference(context));
members.Add("DriveMode", DriveMode.ToResoniteLinkField());
members.Add("Premultiply", Premultiply.ToResoniteLinkField());
members.Add("Ratio", Ratio.ToResoniteLinkField());
members.Add("MaxSize", MaxSize.ToResoniteLinkField());
}

}
}

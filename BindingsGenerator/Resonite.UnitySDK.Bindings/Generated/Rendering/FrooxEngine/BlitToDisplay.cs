
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BlitToDisplay
// Generated on: středa 25. února 2026 16:14:16
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BlitToDisplay")]
public partial class BlitToDisplay : global::FrooxEngine.ChangeHandlingRenderableComponent

{
    public global::FrooxEngine.UserRef TargetUser;
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture> Texture;
public global::System.Int32 DisplayIndex;
public UnityEngine.ColorX BackgroundColor;
public global::System.Boolean FlipHorizontally;
public global::System.Boolean FlipVertically;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetUser", new ResoniteLink.SyncObject() { Members = TargetUser.CollectMembers(context) });
members.Add("Texture", Texture.ToResoniteReference(context));
members.Add("DisplayIndex", DisplayIndex.ToResoniteLinkField());
members.Add("BackgroundColor", BackgroundColor.ToResoniteLinkField());
members.Add("FlipHorizontally", FlipHorizontally.ToResoniteLinkField());
members.Add("FlipVertically", FlipVertically.ToResoniteLinkField());
}

}
}

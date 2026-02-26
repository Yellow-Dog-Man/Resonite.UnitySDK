
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BlitToDisplay
// Generated on: čtvrtek 26. února 2026 10:04:37
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
    public global::FrooxEngine.UserRef TargetUser = new();
public global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture> Texture { get => Texture_Element.Data; set => Texture_Element.Data = value; }
public Field<global::FrooxEngine.AssetRef<global::FrooxEngine.ITexture>, global::FrooxEngine.IAssetProvider<global::FrooxEngine.ITexture>> Texture_Element = new();
public global::System.Int32 DisplayIndex { get => DisplayIndex_Element.Data; set => DisplayIndex_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> DisplayIndex_Element = new();
public UnityEngine.ColorX BackgroundColor { get => BackgroundColor_Element.Data; set => BackgroundColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> BackgroundColor_Element = new();
public global::System.Boolean FlipHorizontally { get => FlipHorizontally_Element.Data; set => FlipHorizontally_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FlipHorizontally_Element = new();
public global::System.Boolean FlipVertically { get => FlipVertically_Element.Data; set => FlipVertically_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FlipVertically_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetUser", new ResoniteLink.SyncObject() { Members = TargetUser.CollectMembers(context) });
members.Add("Texture", Texture_Element.Data.ToResoniteReference(context));
members.Add("DisplayIndex", DisplayIndex_Element.Data.ToResoniteLinkField());
members.Add("BackgroundColor", BackgroundColor_Element.Data.ToResoniteLinkField());
members.Add("FlipHorizontally", FlipHorizontally_Element.Data.ToResoniteLinkField());
members.Add("FlipVertically", FlipVertically_Element.Data.ToResoniteLinkField());
}

}
}

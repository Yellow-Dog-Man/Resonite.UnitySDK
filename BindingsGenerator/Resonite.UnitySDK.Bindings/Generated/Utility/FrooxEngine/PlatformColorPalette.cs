
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PlatformColorPalette
// Generated on: čtvrtek 26. února 2026 15:09:17
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PlatformColorPalette")]
public partial class PlatformColorPalette : global::FrooxEngine.Component

{
    public global::FrooxEngine.PlatformColorPalette.Grayscale Neutrals = new();
public global::FrooxEngine.PlatformColorPalette.Colors Hero = new();
public global::FrooxEngine.PlatformColorPalette.Colors Mid = new();
public global::FrooxEngine.PlatformColorPalette.Colors Sub = new();
public global::FrooxEngine.PlatformColorPalette.Colors Dark = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Neutrals", Neutrals.ToLinkSyncObject(context));
members.Add("Hero", Hero.ToLinkSyncObject(context));
members.Add("Mid", Mid.ToLinkSyncObject(context));
members.Add("Sub", Sub.ToLinkSyncObject(context));
members.Add("Dark", Dark.ToLinkSyncObject(context));
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PlatformColorPalette
// Generated on: středa 25. února 2026 16:14:47
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PlatformColorPalette")]
public partial class PlatformColorPalette : global::FrooxEngine.Component

{
    public global::FrooxEngine.PlatformColorPalette.Grayscale Neutrals;
public global::FrooxEngine.PlatformColorPalette.Colors Hero;
public global::FrooxEngine.PlatformColorPalette.Colors Mid;
public global::FrooxEngine.PlatformColorPalette.Colors Sub;
public global::FrooxEngine.PlatformColorPalette.Colors Dark;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Neutrals", new ResoniteLink.SyncObject() { Members = Neutrals.CollectMembers(context) });
members.Add("Hero", new ResoniteLink.SyncObject() { Members = Hero.CollectMembers(context) });
members.Add("Mid", new ResoniteLink.SyncObject() { Members = Mid.CollectMembers(context) });
members.Add("Sub", new ResoniteLink.SyncObject() { Members = Sub.CollectMembers(context) });
members.Add("Dark", new ResoniteLink.SyncObject() { Members = Dark.CollectMembers(context) });
}

}
}

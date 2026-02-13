
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.PlatformColorPalette
// Generated on: pátek 13. února 2026 5:52:40
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.PlatformColorPalette")]
public partial class PlatformColorPalette : global::FrooxEngine.Component

{
    public global::FrooxEngine.PlatformColorPalette.Grayscale Neutrals;
public global::FrooxEngine.PlatformColorPalette.Colors Hero;
public global::FrooxEngine.PlatformColorPalette.Colors Mid;
public global::FrooxEngine.PlatformColorPalette.Colors Sub;
public global::FrooxEngine.PlatformColorPalette.Colors Dark;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Neutrals", new ResoniteLink.SyncObject() { Members = Neutrals.CollectMembers() });
members.Add("Hero", new ResoniteLink.SyncObject() { Members = Hero.CollectMembers() });
members.Add("Mid", new ResoniteLink.SyncObject() { Members = Mid.CollectMembers() });
members.Add("Sub", new ResoniteLink.SyncObject() { Members = Sub.CollectMembers() });
members.Add("Dark", new ResoniteLink.SyncObject() { Members = Dark.CollectMembers() });
}

}
}

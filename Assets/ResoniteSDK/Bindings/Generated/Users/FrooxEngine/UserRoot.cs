
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UserRoot
// Generated on: pátek 13. února 2026 5:51:44
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UserRoot")]
public partial class UserRoot : global::FrooxEngine.Component

{
    public global::FrooxEngine.IRenderSettingsSource RenderSettings;
public global::FrooxEngine.ScreenController ScreenController;
public global::FrooxEngine.Slot OverrideRoot;
public global::FrooxEngine.Slot OverrideView;
public global::FrooxEngine.AudioListener PrimaryListener;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("RenderSettings", new ResoniteLink.Reference() { });
members.Add("ScreenController", new ResoniteLink.Reference() { });
members.Add("OverrideRoot", new ResoniteLink.Reference() { });
members.Add("OverrideView", new ResoniteLink.Reference() { });
members.Add("PrimaryListener", new ResoniteLink.Reference() { });
}

}
}

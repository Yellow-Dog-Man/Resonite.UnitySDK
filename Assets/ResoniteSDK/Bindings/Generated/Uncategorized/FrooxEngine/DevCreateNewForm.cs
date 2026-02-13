
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DevCreateNewForm
// Generated on: pátek 13. února 2026 23:23:13
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DevCreateNewForm")]
public partial class DevCreateNewForm : global::FrooxEngine.Component, global::FrooxEngine.IDeveloperInterface

{
    public global::System.String CategoryRoot;
public global::FrooxEngine.Slot _contentRoot;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("CategoryRoot", CategoryRoot.ToResoniteLinkField());
members.Add("_contentRoot", new ResoniteLink.Reference() { });
}

}
}

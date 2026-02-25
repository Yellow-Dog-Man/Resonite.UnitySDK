
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DevCreateNewForm
// Generated on: středa 25. února 2026 16:14:37
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DevCreateNewForm")]
public partial class DevCreateNewForm : global::FrooxEngine.Component, global::FrooxEngine.IDeveloperInterface

{
    public global::System.String CategoryRoot;
public global::FrooxEngine.Slot _contentRoot;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CategoryRoot", CategoryRoot.ToResoniteLinkField());
members.Add("_contentRoot", _contentRoot.ToResoniteReference(context));
}

}
}

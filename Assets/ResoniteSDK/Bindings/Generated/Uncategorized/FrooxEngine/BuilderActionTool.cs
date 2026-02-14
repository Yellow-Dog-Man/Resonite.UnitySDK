
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BuilderActionTool
// Generated on: sobota 14. února 2026 8:58:36
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BuilderActionTool")]
public abstract partial class BuilderActionTool : global::FrooxEngine.Tool

{
    public global::System.Boolean ApplyToObjectRoot;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ApplyToObjectRoot", ApplyToObjectRoot.ToResoniteLinkField());
}

}
}

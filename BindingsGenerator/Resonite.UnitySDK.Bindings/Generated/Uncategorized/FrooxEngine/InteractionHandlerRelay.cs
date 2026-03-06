
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractionHandlerRelay
// Generated on: pátek 6. března 2026 14:19:09
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractionHandlerRelay")]
public partial class InteractionHandlerRelay : global::FrooxEngine.Component

{
    public global::FrooxEngine.InteractionHandler CommonTool { get => CommonTool_Element.Data; set => CommonTool_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.InteractionHandler>, global::FrooxEngine.InteractionHandler> CommonTool_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CommonTool", CommonTool_Element.ToLinkReference(context));
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DebugUsers
// Generated on: pátek 6. března 2026 14:18:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DebugUsers")]
public partial class DebugUsers : global::FrooxEngine.Component

{
    public global::FrooxEngine.Sync<global::System.String> text { get => text_Element.Data; set => text_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.Sync<global::System.String>>, global::FrooxEngine.Sync<global::System.String>> text_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("text", text_Element.ToLinkReference(context));
}

}
}

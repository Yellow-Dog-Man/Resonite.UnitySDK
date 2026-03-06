
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ReferenceProxySource
// Generated on: pátek 6. března 2026 14:19:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ReferenceProxySource")]
public partial class ReferenceProxySource : global::FrooxEngine.Component, global::FrooxEngine.UIX.IUIGrabbable

{
    public global::FrooxEngine.IWorldElement Reference { get => Reference_Element.Data; set => Reference_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef, global::FrooxEngine.IWorldElement> Reference_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Reference", Reference_Element.ToLinkReference(context));
}

}
}

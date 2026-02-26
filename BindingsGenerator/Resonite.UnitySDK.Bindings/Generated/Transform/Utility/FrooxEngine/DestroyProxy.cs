
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DestroyProxy
// Generated on: čtvrtek 26. února 2026 12:28:08
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DestroyProxy")]
public partial class DestroyProxy : global::FrooxEngine.Component

{
    public global::FrooxEngine.IDestroyable DestroyTarget { get => DestroyTarget_Element.Data; set => DestroyTarget_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IDestroyable>, global::FrooxEngine.IDestroyable> DestroyTarget_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DestroyTarget", DestroyTarget_Element.ToLinkReference(context));
}

}
}

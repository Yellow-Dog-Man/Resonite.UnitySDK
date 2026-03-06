
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonDestroy
// Generated on: pátek 6. března 2026 14:18:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonDestroy")]
public partial class ButtonDestroy : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::FrooxEngine.IDestroyable Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IDestroyable>, global::FrooxEngine.IDestroyable> Target_Element = new();
public global::System.Boolean FindObjectRoot { get => FindObjectRoot_Element.Data; set => FindObjectRoot_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FindObjectRoot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("FindObjectRoot", FindObjectRoot_Element.ToLinkField(context));
}

}
}

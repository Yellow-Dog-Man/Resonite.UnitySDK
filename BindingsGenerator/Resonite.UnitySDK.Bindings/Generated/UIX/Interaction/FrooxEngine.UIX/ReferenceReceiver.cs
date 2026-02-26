
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ReferenceReceiver
// Generated on: čtvrtek 26. února 2026 12:28:09
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.UIX
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.UIX.ReferenceReceiver")]
public partial class ReferenceReceiver : global::FrooxEngine.Component, global::FrooxEngine.UIX.IUIGrabReceiver

{
    public global::FrooxEngine.ISyncRef TargetReference { get => TargetReference_Element.Data; set => TargetReference_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ISyncRef>, global::FrooxEngine.ISyncRef> TargetReference_Element = new();
public global::System.Boolean Undoable { get => Undoable_Element.Data; set => Undoable_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Undoable_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetReference", TargetReference_Element.ToLinkReference(context));
members.Add("Undoable", Undoable_Element.ToLinkField(context));
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.UIX.ReferenceReceiver
// Generated on: sobota 14. února 2026 8:58:41
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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
    public global::FrooxEngine.ISyncRef TargetReference;
public global::System.Boolean Undoable;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetReference", TargetReference.ToResoniteReference(context));
members.Add("Undoable", Undoable.ToResoniteLinkField());
}

}
}

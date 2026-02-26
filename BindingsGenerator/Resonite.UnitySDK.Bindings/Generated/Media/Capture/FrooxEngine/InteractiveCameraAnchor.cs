
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.InteractiveCameraAnchor
// Generated on: čtvrtek 26. února 2026 15:08:01
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.InteractiveCameraAnchor")]
public partial class InteractiveCameraAnchor : global::FrooxEngine.Component, global::FrooxEngine.ITouchable

{
    public global::FrooxEngine.Slot OverrideRoot { get => OverrideRoot_Element.Data; set => OverrideRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> OverrideRoot_Element = new();
public global::System.Single FieldOfView { get => FieldOfView_Element.Data; set => FieldOfView_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> FieldOfView_Element = new();
public global::System.Boolean Highlighted { get => Highlighted_Element.Data; set => Highlighted_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Highlighted_Element = new();
public global::System.Boolean InUse { get => InUse_Element.Data; set => InUse_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> InUse_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("OverrideRoot", OverrideRoot_Element.ToLinkReference(context));
members.Add("FieldOfView", FieldOfView_Element.ToLinkField(context));
members.Add("Highlighted", Highlighted_Element.ToLinkField(context));
members.Add("InUse", InUse_Element.ToLinkField(context));
}

}
}

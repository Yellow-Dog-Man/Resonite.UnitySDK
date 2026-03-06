
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MaterialGizmo
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MaterialGizmo")]
public partial class MaterialGizmo : global::FrooxEngine.Component, global::FrooxEngine.IComponentGizmo

{
    public global::FrooxEngine.MaterialProvider _target { get => _target_Element.Data; set => _target_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.MaterialProvider>, global::FrooxEngine.MaterialProvider> _target_Element = new();
public global::FrooxEngine.Slot _inspectorRoot { get => _inspectorRoot_Element.Data; set => _inspectorRoot_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _inspectorRoot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_target", _target_Element.ToLinkReference(context));
members.Add("_inspectorRoot", _inspectorRoot_Element.ToLinkReference(context));
}

}
}

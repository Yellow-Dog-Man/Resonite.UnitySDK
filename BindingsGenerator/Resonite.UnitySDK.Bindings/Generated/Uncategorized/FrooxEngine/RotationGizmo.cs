
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RotationGizmo
// Generated on: pátek 6. března 2026 14:19:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RotationGizmo")]
public partial class RotationGizmo : global::FrooxEngine.Component

{
    public global::FrooxEngine.AxisRotationGizmo _xGizmo { get => _xGizmo_Element.Data; set => _xGizmo_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AxisRotationGizmo>, global::FrooxEngine.AxisRotationGizmo> _xGizmo_Element = new();
public global::FrooxEngine.AxisRotationGizmo _yGizmo { get => _yGizmo_Element.Data; set => _yGizmo_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AxisRotationGizmo>, global::FrooxEngine.AxisRotationGizmo> _yGizmo_Element = new();
public global::FrooxEngine.AxisRotationGizmo _zGizmo { get => _zGizmo_Element.Data; set => _zGizmo_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AxisRotationGizmo>, global::FrooxEngine.AxisRotationGizmo> _zGizmo_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_xGizmo", _xGizmo_Element.ToLinkReference(context));
members.Add("_yGizmo", _yGizmo_Element.ToLinkReference(context));
members.Add("_zGizmo", _zGizmo_Element.ToLinkReference(context));
}

}
}

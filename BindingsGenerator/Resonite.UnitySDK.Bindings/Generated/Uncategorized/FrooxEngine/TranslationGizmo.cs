
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TranslationGizmo
// Generated on: čtvrtek 26. února 2026 15:09:14
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TranslationGizmo")]
public partial class TranslationGizmo : global::FrooxEngine.Component

{
    public global::FrooxEngine.VolumeTranslationGizmo _xyzGizmo { get => _xyzGizmo_Element.Data; set => _xyzGizmo_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.VolumeTranslationGizmo>, global::FrooxEngine.VolumeTranslationGizmo> _xyzGizmo_Element = new();
public global::FrooxEngine.PlaneTranslationGizmo _xyGizmo { get => _xyGizmo_Element.Data; set => _xyGizmo_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.PlaneTranslationGizmo>, global::FrooxEngine.PlaneTranslationGizmo> _xyGizmo_Element = new();
public global::FrooxEngine.PlaneTranslationGizmo _xzGizmo { get => _xzGizmo_Element.Data; set => _xzGizmo_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.PlaneTranslationGizmo>, global::FrooxEngine.PlaneTranslationGizmo> _xzGizmo_Element = new();
public global::FrooxEngine.PlaneTranslationGizmo _yzGizmo { get => _yzGizmo_Element.Data; set => _yzGizmo_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.PlaneTranslationGizmo>, global::FrooxEngine.PlaneTranslationGizmo> _yzGizmo_Element = new();
public global::FrooxEngine.AxisTranslationGizmo _xGizmo { get => _xGizmo_Element.Data; set => _xGizmo_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AxisTranslationGizmo>, global::FrooxEngine.AxisTranslationGizmo> _xGizmo_Element = new();
public global::FrooxEngine.AxisTranslationGizmo _yGizmo { get => _yGizmo_Element.Data; set => _yGizmo_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AxisTranslationGizmo>, global::FrooxEngine.AxisTranslationGizmo> _yGizmo_Element = new();
public global::FrooxEngine.AxisTranslationGizmo _zGizmo { get => _zGizmo_Element.Data; set => _zGizmo_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.AxisTranslationGizmo>, global::FrooxEngine.AxisTranslationGizmo> _zGizmo_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_xyzGizmo", _xyzGizmo_Element.ToLinkReference(context));
members.Add("_xyGizmo", _xyGizmo_Element.ToLinkReference(context));
members.Add("_xzGizmo", _xzGizmo_Element.ToLinkReference(context));
members.Add("_yzGizmo", _yzGizmo_Element.ToLinkReference(context));
members.Add("_xGizmo", _xGizmo_Element.ToLinkReference(context));
members.Add("_yGizmo", _yGizmo_Element.ToLinkReference(context));
members.Add("_zGizmo", _zGizmo_Element.ToLinkReference(context));
}

}
}

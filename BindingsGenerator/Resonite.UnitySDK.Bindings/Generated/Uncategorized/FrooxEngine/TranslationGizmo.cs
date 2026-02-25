
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TranslationGizmo
// Generated on: středa 25. února 2026 16:14:43
// Resonite version: 2026.2.25.455
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TranslationGizmo")]
public partial class TranslationGizmo : global::FrooxEngine.Component

{
    public global::FrooxEngine.VolumeTranslationGizmo _xyzGizmo;
public global::FrooxEngine.PlaneTranslationGizmo _xyGizmo;
public global::FrooxEngine.PlaneTranslationGizmo _xzGizmo;
public global::FrooxEngine.PlaneTranslationGizmo _yzGizmo;
public global::FrooxEngine.AxisTranslationGizmo _xGizmo;
public global::FrooxEngine.AxisTranslationGizmo _yGizmo;
public global::FrooxEngine.AxisTranslationGizmo _zGizmo;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_xyzGizmo", _xyzGizmo.ToResoniteReference(context));
members.Add("_xyGizmo", _xyGizmo.ToResoniteReference(context));
members.Add("_xzGizmo", _xzGizmo.ToResoniteReference(context));
members.Add("_yzGizmo", _yzGizmo.ToResoniteReference(context));
members.Add("_xGizmo", _xGizmo.ToResoniteReference(context));
members.Add("_yGizmo", _yGizmo.ToResoniteReference(context));
members.Add("_zGizmo", _zGizmo.ToResoniteReference(context));
}

}
}

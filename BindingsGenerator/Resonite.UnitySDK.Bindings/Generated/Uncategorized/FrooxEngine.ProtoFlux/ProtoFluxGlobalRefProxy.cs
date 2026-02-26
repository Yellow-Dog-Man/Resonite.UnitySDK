
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxGlobalRefProxy
// Generated on: čtvrtek 26. února 2026 10:04:47
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxGlobalRefProxy")]
public partial class ProtoFluxGlobalRefProxy : global::FrooxEngine.ProtoFlux.ProtoFluxRefProxy, global::FrooxEngine.UIX.IUIGrabReceiver

{
    public global::FrooxEngine.ISyncRef TargetGlobalRef { get => TargetGlobalRef_Element.Data; set => TargetGlobalRef_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.ISyncRef>, global::FrooxEngine.ISyncRef> TargetGlobalRef_Element = new();
public global::FrooxEngine.ProtoFlux.IGlobalValueProxy _currentProxy { get => _currentProxy_Element.Data; set => _currentProxy_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.ProtoFlux.IGlobalValueProxy>, global::FrooxEngine.ProtoFlux.IGlobalValueProxy> _currentProxy_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetGlobalRef", TargetGlobalRef_Element.Data.ToResoniteReference(context));
members.Add("_currentProxy", _currentProxy_Element.Data.ToResoniteReference(context));
}

}
}

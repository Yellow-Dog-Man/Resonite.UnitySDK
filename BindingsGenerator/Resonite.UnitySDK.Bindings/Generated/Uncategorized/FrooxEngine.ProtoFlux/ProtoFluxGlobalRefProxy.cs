
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxGlobalRefProxy
// Generated on: středa 25. února 2026 16:14:42
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
    public global::FrooxEngine.ISyncRef TargetGlobalRef;
public global::FrooxEngine.ProtoFlux.IGlobalValueProxy _currentProxy;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetGlobalRef", TargetGlobalRef.ToResoniteReference(context));
members.Add("_currentProxy", _currentProxy.ToResoniteReference(context));
}

}
}

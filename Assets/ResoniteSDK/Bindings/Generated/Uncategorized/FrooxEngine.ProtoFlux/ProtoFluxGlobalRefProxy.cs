
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.ProtoFluxGlobalRefProxy
// Generated on: pátek 13. února 2026 23:23:17
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("TargetGlobalRef", new ResoniteLink.Reference() { });
members.Add("_currentProxy", new ResoniteLink.Reference() { });
}

}
}

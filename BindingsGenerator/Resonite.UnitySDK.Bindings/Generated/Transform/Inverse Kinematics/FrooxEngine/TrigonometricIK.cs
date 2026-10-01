
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TrigonometricIK
// Generated on: pátek 14. srpna 2026 21:57:42
// Resonite version: 2026.8.12.1196
// Resonite Link Version: 0.13.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TrigonometricIK")]
public partial class TrigonometricIK : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot TargetEffector { get => TargetEffector_Element.Data; set => TargetEffector_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> TargetEffector_Element = new();
public global::FrooxEngine.Slot BendEffector { get => BendEffector_Element.Data; set => BendEffector_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> BendEffector_Element = new();
public global::FrooxEngine.ChainBone BaseBone = new();
public global::FrooxEngine.ChainBone MidBone = new();
public global::FrooxEngine.ChainBone EndBone = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetEffector", TargetEffector_Element.ToLinkReference(context));
members.Add("BendEffector", BendEffector_Element.ToLinkReference(context));
members.Add("BaseBone", BaseBone.ToLinkSyncObject(context));
members.Add("MidBone", MidBone.ToLinkSyncObject(context));
members.Add("EndBone", EndBone.ToLinkSyncObject(context));
}

}
}

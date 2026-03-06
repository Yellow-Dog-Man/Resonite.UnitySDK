
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.BipedRig
// Generated on: pátek 6. března 2026 14:19:03
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.BipedRig")]
public partial class BipedRig : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public global::System.Nullable<UnityEngine.Vector3> ForwardAxis { get => ForwardAxis_Element.Data; set => ForwardAxis_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Nullable<UnityEngine.Vector3>>, global::System.Nullable<UnityEngine.Vector3>> ForwardAxis_Element = new();
public global::SyncDictionary<global::FrooxEngine.SyncRefDictionary<global::Renderite.Shared.BodyNode,global::FrooxEngine.Slot>, global::Renderite.Shared.BodyNode, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot>> Bones = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ForwardAxis", ForwardAxis_Element.ToLinkField(context));
members.Add("Bones", Bones.ToLinkDictionary(context, m => m.ToLinkReference(context)));
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FABRIK_Chain+ChainBone
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
    public partial class FABRIK_Chain
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FABRIK_Chain+ChainBone")]
public partial class ChainBone : global::FrooxEngine.ParentableChainBone<global::FrooxEngine.FABRIK_Chain.ChainBone>

{
    public global::FrooxEngine.Slot Effector { get => Effector_Element.Data; set => Effector_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Effector_Element = new();
public global::System.Int32 EffectorPriority { get => EffectorPriority_Element.Data; set => EffectorPriority_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> EffectorPriority_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Effector", Effector_Element.ToLinkReference(context));
members.Add("EffectorPriority", EffectorPriority_Element.ToLinkField(context));
}

}
            }
}

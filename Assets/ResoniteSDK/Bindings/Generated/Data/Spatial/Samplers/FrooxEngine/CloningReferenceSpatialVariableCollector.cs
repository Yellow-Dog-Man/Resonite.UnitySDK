
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.CloningReferenceSpatialVariableCollector
// Generated on: čtvrtek 19. února 2026 7:58:57
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.CloningReferenceSpatialVariableCollector")]
public abstract partial class CloningReferenceSpatialVariableCollector : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot CloneParent;
public global::System.Boolean MakeClonesLocal;
public global::System.String VariableName;
public global::FrooxEngine.CloningReferenceSpatialVariableCollector.CloneMode Mode;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CloneParent", CloneParent.ToResoniteReference(context));
members.Add("MakeClonesLocal", MakeClonesLocal.ToResoniteLinkField());
members.Add("VariableName", VariableName.ToResoniteLinkField());
members.Add("Mode", Mode.ToResoniteLinkField());
}

}
}

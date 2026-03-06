
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.CoreNodes.FieldHookBase<>+Proxy
// Generated on: pátek 6. března 2026 14:18:37
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.CoreNodes
{
    public partial class FieldHookBase<T>
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.CoreNodes.FieldHookBase<>+Proxy")]
public partial class Proxy : global::FrooxEngine.ProtoFlux.ProtoFluxEngineProxy

{
    public global::FrooxEngine.IField<T> Drive { get => Drive_Element.Data; set => Drive_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<T>, global::FrooxEngine.IField<T>> Drive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Drive", Drive_Element.ToLinkReference(context));
}

}
            }
}

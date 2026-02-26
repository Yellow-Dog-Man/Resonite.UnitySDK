
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GaussianSplatTool+BoxInterface
// Generated on: čtvrtek 26. února 2026 12:28:05
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public partial class GaussianSplatTool
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GaussianSplatTool+BoxInterface")]
public partial class BoxInterface : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Vector3> Size { get => Size_Element.Data; set => Size_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<UnityEngine.Vector3>>, global::FrooxEngine.IField<UnityEngine.Vector3>> Size_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Size", Size_Element.ToLinkReference(context));
}

}
            }
}

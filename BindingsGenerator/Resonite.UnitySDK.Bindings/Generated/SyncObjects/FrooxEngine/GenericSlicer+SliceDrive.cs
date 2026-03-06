
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GenericSlicer+SliceDrive
// Generated on: pátek 6. března 2026 14:19:05
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
    public partial class GenericSlicer
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GenericSlicer+SliceDrive")]
public partial class SliceDrive : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.IField<UnityEngine.Vector3> Position { get => Position_Element.Data; set => Position_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> Position_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector3> Normal { get => Normal_Element.Data; set => Normal_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.Vector3>, global::FrooxEngine.IField<UnityEngine.Vector3>> Normal_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Position", Position_Element.ToLinkReference(context));
members.Add("Normal", Normal_Element.ToLinkReference(context));
}

}
            }
}

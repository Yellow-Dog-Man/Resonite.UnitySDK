
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RigMeshTransferTool
// Generated on: středa 25. února 2026 16:14:25
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RigMeshTransferTool")]
public partial class RigMeshTransferTool : global::FrooxEngine.Tool

{
    public global::FrooxEngine.Rig SourceRig;
public global::FrooxEngine.TextRenderer _label;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SourceRig", SourceRig.ToResoniteReference(context));
members.Add("_label", _label.ToResoniteReference(context));
}

}
}

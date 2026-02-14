
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RigMeshTransferTool
// Generated on: sobota 14. února 2026 8:58:38
// Resonite version: 2026.2.14.493
// Resonite Link Version: 0.7.0.0
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


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RigMeshTransferTool
// Generated on: čtvrtek 26. února 2026 15:09:06
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
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
    public global::FrooxEngine.Rig SourceRig { get => SourceRig_Element.Data; set => SourceRig_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Rig>, global::FrooxEngine.Rig> SourceRig_Element = new();
public global::FrooxEngine.TextRenderer _label { get => _label_Element.Data; set => _label_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> _label_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SourceRig", SourceRig_Element.ToLinkReference(context));
members.Add("_label", _label_Element.ToLinkReference(context));
}

}
}

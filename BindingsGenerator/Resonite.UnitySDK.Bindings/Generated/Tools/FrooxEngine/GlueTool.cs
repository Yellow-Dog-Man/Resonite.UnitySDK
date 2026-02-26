
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GlueTool
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GlueTool")]
public partial class GlueTool : global::FrooxEngine.Tool

{
    public global::FrooxEngine.Glue.Mode GlueMode { get => GlueMode_Element.Data; set => GlueMode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Glue.Mode>, global::FrooxEngine.Glue.Mode> GlueMode_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _indicatorColor { get => _indicatorColor_Element.Data; set => _indicatorColor_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _indicatorColor_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.Glue>, global::FrooxEngine.Glue, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Glue>, global::FrooxEngine.Glue>> _activeGlues = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("GlueMode", GlueMode_Element.ToLinkField(context));
members.Add("_indicatorColor", _indicatorColor_Element.ToLinkReference(context));
members.Add("_activeGlues", _activeGlues.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}

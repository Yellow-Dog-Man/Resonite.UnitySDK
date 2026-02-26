
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MeshRendererLoadStatus
// Generated on: čtvrtek 26. února 2026 15:09:18
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MeshRendererLoadStatus")]
public partial class MeshRendererLoadStatus : global::FrooxEngine.Component

{
    public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.MeshRenderer>, global::FrooxEngine.MeshRenderer>> Renderers = new();
public global::System.Boolean IsLoaded { get => IsLoaded_Element.Data; set => IsLoaded_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsLoaded_Element = new();
public global::System.Single LoadProgress { get => LoadProgress_Element.Data; set => LoadProgress_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> LoadProgress_Element = new();
public global::System.Single ProgressWeight { get => ProgressWeight_Element.Data; set => ProgressWeight_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Single>, global::System.Single> ProgressWeight_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Renderers", Renderers.ToLinkList(context, m => m.ToLinkReference(context)));
members.Add("IsLoaded", IsLoaded_Element.ToLinkField(context));
members.Add("LoadProgress", LoadProgress_Element.ToLinkField(context));
members.Add("ProgressWeight", ProgressWeight_Element.ToLinkField(context));
}

}
}

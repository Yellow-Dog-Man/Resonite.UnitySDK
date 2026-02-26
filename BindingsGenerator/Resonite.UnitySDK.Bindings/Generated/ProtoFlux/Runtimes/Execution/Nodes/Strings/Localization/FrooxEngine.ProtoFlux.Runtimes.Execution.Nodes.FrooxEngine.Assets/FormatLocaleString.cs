
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.FormatLocaleString
// Generated on: čtvrtek 26. února 2026 12:27:55
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Assets.FormatLocaleString")]
public partial class FormatLocaleString : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ObjectFunctionNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext,global::System.String>

{
    public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.LocaleResource> Locale { get => Locale_Element.Data; set => Locale_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.LocaleResource>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::FrooxEngine.LocaleResource>> Locale_Element = new();
public global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String> Key { get => Key_Element.Data; set => Key_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>>, global::FrooxEngine.ProtoFlux.INodeObjectOutput<global::System.String>> Key_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Locale", Locale_Element.ToLinkReference(context));
members.Add("Key", Key_Element.ToLinkReference(context));
}

}
}

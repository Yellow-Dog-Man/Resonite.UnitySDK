
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.TextEditorEvents
// Generated on: čtvrtek 26. února 2026 10:04:15
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.TextEditorEvents")]
public partial class TextEditorEvents : global::FrooxEngine.ProtoFlux.Runtimes.Execution.VoidNode<global::FrooxEngine.ProtoFlux.FrooxEngineContext>

{
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.TextEditor> Editor { get => Editor_Element.Data; set => Editor_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.TextEditor>>, global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.TextEditor>> Editor_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation EditingStarted { get => EditingStarted_Element.Data; set => EditingStarted_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> EditingStarted_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation EditingChanged { get => EditingChanged_Element.Data; set => EditingChanged_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> EditingChanged_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation EditingFinished { get => EditingFinished_Element.Data; set => EditingFinished_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> EditingFinished_Element = new();
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation SubmitPressed { get => SubmitPressed_Element.Data; set => SubmitPressed_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.ProtoFlux.ISyncNodeOperation>, global::FrooxEngine.ProtoFlux.ISyncNodeOperation> SubmitPressed_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Editor", Editor_Element.Data.ToResoniteReference(context));
members.Add("EditingStarted", EditingStarted_Element.Data.ToResoniteReference(context));
members.Add("EditingChanged", EditingChanged_Element.Data.ToResoniteReference(context));
members.Add("EditingFinished", EditingFinished_Element.Data.ToResoniteReference(context));
members.Add("SubmitPressed", SubmitPressed_Element.Data.ToResoniteReference(context));
}

}
}

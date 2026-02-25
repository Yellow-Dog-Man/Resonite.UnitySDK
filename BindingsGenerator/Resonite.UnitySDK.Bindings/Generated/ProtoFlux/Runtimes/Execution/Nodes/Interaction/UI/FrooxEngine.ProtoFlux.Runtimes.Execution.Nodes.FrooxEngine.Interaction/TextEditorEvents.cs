
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.TextEditorEvents
// Generated on: středa 25. února 2026 16:13:47
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
    public global::FrooxEngine.ProtoFlux.IGlobalValueProxy<global::FrooxEngine.TextEditor> Editor;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation EditingStarted;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation EditingChanged;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation EditingFinished;
public global::FrooxEngine.ProtoFlux.ISyncNodeOperation SubmitPressed;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Editor", Editor.ToResoniteReference(context));
members.Add("EditingStarted", EditingStarted.ToResoniteReference(context));
members.Add("EditingChanged", EditingChanged.ToResoniteReference(context));
members.Add("EditingFinished", EditingFinished.ToResoniteReference(context));
members.Add("SubmitPressed", SubmitPressed.ToResoniteReference(context));
}

}
}

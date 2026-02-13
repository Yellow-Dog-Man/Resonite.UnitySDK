
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Interaction.TextEditorEvents
// Generated on: pátek 13. února 2026 5:51:54
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Editor", new ResoniteLink.Reference() { });
members.Add("EditingStarted", new ResoniteLink.Reference() { });
members.Add("EditingChanged", new ResoniteLink.Reference() { });
members.Add("EditingFinished", new ResoniteLink.Reference() { });
members.Add("SubmitPressed", new ResoniteLink.Reference() { });
}

}
}

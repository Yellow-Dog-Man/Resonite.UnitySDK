
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Audio.ConstructZitaParameters
// Generated on: středa 25. února 2026 16:13:37
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Audio
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Audio.ConstructZitaParameters")]
public partial class ConstructZitaParameters : global::FrooxEngine.ProtoFlux.Runtimes.Execution.ValueFunctionNode<global::ProtoFlux.Runtimes.Execution.ExecutionContext,global::SharpPipe.ZitaParameters>

{
    public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> InDelay;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Crossover;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> RT60Low;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> RT60Mid;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> HighFrequencyDamping;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> EQ1Frequency;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> EQ1Level;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> EQ2Frequency;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> EQ2Level;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Mix;
public global::FrooxEngine.ProtoFlux.INodeValueOutput<global::System.Single> Level;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("InDelay", InDelay.ToResoniteReference(context));
members.Add("Crossover", Crossover.ToResoniteReference(context));
members.Add("RT60Low", RT60Low.ToResoniteReference(context));
members.Add("RT60Mid", RT60Mid.ToResoniteReference(context));
members.Add("HighFrequencyDamping", HighFrequencyDamping.ToResoniteReference(context));
members.Add("EQ1Frequency", EQ1Frequency.ToResoniteReference(context));
members.Add("EQ1Level", EQ1Level.ToResoniteReference(context));
members.Add("EQ2Frequency", EQ2Frequency.ToResoniteReference(context));
members.Add("EQ2Level", EQ2Level.ToResoniteReference(context));
members.Add("Mix", Mix.ToResoniteReference(context));
members.Add("Level", Level.ToResoniteReference(context));
}

}
}

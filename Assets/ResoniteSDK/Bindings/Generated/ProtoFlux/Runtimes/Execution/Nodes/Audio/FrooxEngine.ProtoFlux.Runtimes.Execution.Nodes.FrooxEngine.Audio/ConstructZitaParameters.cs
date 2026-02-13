
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Audio.ConstructZitaParameters
// Generated on: pátek 13. února 2026 23:22:18
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("InDelay", new ResoniteLink.Reference() { });
members.Add("Crossover", new ResoniteLink.Reference() { });
members.Add("RT60Low", new ResoniteLink.Reference() { });
members.Add("RT60Mid", new ResoniteLink.Reference() { });
members.Add("HighFrequencyDamping", new ResoniteLink.Reference() { });
members.Add("EQ1Frequency", new ResoniteLink.Reference() { });
members.Add("EQ1Level", new ResoniteLink.Reference() { });
members.Add("EQ2Frequency", new ResoniteLink.Reference() { });
members.Add("EQ2Level", new ResoniteLink.Reference() { });
members.Add("Mix", new ResoniteLink.Reference() { });
members.Add("Level", new ResoniteLink.Reference() { });
}

}
}

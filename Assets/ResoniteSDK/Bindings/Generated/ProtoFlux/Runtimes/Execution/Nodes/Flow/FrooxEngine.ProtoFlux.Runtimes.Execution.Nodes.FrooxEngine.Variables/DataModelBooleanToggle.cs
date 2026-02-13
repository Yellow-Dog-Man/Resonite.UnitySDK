
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.DataModelBooleanToggle
// Generated on: pátek 13. února 2026 5:51:52
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables
{
    [Serializable]
[ResoniteTypeName("[ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.DataModelBooleanToggle")]
public partial class DataModelBooleanToggle : global::FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.DataModelValueFieldStore<global::System.Boolean>

{
    public global::FrooxEngine.ProtoFlux.SyncNodeOperation Set;
public global::FrooxEngine.ProtoFlux.SyncNodeOperation Reset;
public global::FrooxEngine.ProtoFlux.SyncNodeOperation Toggle;
public global::FrooxEngine.ProtoFlux.INodeOperation OnSet;
public global::FrooxEngine.ProtoFlux.INodeOperation OnReset;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Set", new ResoniteLink.EmptyElement());
members.Add("Reset", new ResoniteLink.EmptyElement());
members.Add("Toggle", new ResoniteLink.EmptyElement());
members.Add("OnSet", new ResoniteLink.Reference() { });
members.Add("OnReset", new ResoniteLink.Reference() { });
}

}
}

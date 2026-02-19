
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFluxBindings]FrooxEngine.ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.DataModelBooleanToggle
// Generated on: čtvrtek 19. února 2026 7:59:50
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
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

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Set", new ResoniteLink.EmptyElement());
members.Add("Reset", new ResoniteLink.EmptyElement());
members.Add("Toggle", new ResoniteLink.EmptyElement());
members.Add("OnSet", OnSet.ToResoniteReference(context));
members.Add("OnReset", OnReset.ToResoniteReference(context));
}

}
}

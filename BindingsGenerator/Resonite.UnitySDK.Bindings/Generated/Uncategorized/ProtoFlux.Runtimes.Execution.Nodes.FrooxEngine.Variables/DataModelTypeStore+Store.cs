
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [ProtoFlux.Nodes.FrooxEngine]ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.DataModelTypeStore+Store
// Generated on: středa 25. února 2026 16:14:13
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables
{
    public partial class DataModelTypeStore
            {
                [Serializable]
[ResoniteTypeName("[ProtoFlux.Nodes.FrooxEngine]ProtoFlux.Runtimes.Execution.Nodes.FrooxEngine.Variables.DataModelTypeStore+Store")]
public partial class Store : global::FrooxEngine.ProtoFlux.ProtoFluxEngineProxy

{
    public System.String Value;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Value", Value.ToResoniteLinkField());
}

}
            }
}

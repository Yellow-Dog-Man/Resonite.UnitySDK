
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ProtoFlux.CoreNodes.FieldDriveBase<>+Proxy
// Generated on: úterý 24. února 2026 18:19:01
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.ProtoFlux.CoreNodes
{
    public partial class FieldDriveBase<T>
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ProtoFlux.CoreNodes.FieldDriveBase<>+Proxy")]
public partial class Proxy : global::FrooxEngine.ProtoFlux.ProtoFluxEngineProxy

{
    public global::FrooxEngine.IField<T> Drive;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Drive", Drive.ToResoniteReference(context));
}

}
            }
}

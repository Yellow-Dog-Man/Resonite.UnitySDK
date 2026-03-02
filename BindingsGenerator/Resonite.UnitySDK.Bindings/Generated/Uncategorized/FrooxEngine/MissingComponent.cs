
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MissingComponent
// Generated on: pondělí 2. března 2026 17:53:35
// Resonite version: 2026.3.2.1000
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MissingComponent")]
public partial class MissingComponent : global::FrooxEngine.Component

{
    public global::System.String Type { get => Type_Element.Data; set => Type_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Type_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Type", Type_Element.ToLinkField(context));
}

}
}

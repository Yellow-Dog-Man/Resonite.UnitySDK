
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.AmbientLightSH2
// Generated on: pondělí 2. března 2026 17:53:28
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.AmbientLightSH2")]
public partial class AmbientLightSH2 : global::FrooxEngine.Component, global::FrooxEngine.ICustomInspector

{
    public global::Elements.Core.SphericalHarmonicsL2<UnityEngine.ColorX> AmbientLight { get => AmbientLight_Element.Data; set => AmbientLight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Elements.Core.SphericalHarmonicsL2<UnityEngine.ColorX>>, global::Elements.Core.SphericalHarmonicsL2<UnityEngine.ColorX>> AmbientLight_Element = new();
public global::System.Boolean IsActive { get => IsActive_Element.Data; set => IsActive_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> IsActive_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("AmbientLight", AmbientLight_Element.ToLinkField(context));
members.Add("IsActive", IsActive_Element.ToLinkField(context));
}

}
}

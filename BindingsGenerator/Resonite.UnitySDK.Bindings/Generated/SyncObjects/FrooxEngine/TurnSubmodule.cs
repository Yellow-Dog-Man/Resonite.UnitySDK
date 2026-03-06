
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TurnSubmodule
// Generated on: pátek 6. března 2026 14:18:09
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TurnSubmodule")]
public partial class TurnSubmodule : global::FrooxEngine.SyncObject

{
    public global::System.Boolean ThreeAxisRotation { get => ThreeAxisRotation_Element.Data; set => ThreeAxisRotation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ThreeAxisRotation_Element = new();
public global::FrooxEngine.LocomotionController _controller { get => _controller_Element.Data; set => _controller_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.LocomotionController>, global::FrooxEngine.LocomotionController> _controller_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ThreeAxisRotation", ThreeAxisRotation_Element.ToLinkField(context));
members.Add("_controller", _controller_Element.ToLinkReference(context));
}

}
}

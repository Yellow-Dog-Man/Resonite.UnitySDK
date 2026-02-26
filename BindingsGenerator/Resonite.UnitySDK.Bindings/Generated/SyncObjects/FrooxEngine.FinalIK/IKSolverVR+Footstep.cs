
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.IKSolverVR+Footstep
// Generated on: čtvrtek 26. února 2026 10:04:45
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.FinalIK
{
    public partial class IKSolverVR
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FinalIK.IKSolverVR+Footstep")]
public partial class Footstep : global::FrooxEngine.SyncObject

{
    public global::System.Boolean _initialized { get => _initialized_Element.Data; set => _initialized_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _initialized_Element = new();
public UnityEngine.Quaternion footRelativeToRoot { get => footRelativeToRoot_Element.Data; set => footRelativeToRoot_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Quaternion>, UnityEngine.Quaternion> footRelativeToRoot_Element = new();
public global::System.Single footGroundHeight { get => footGroundHeight_Element.Data; set => footGroundHeight_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> footGroundHeight_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_initialized", _initialized_Element.Data.ToResoniteLinkField());
members.Add("footRelativeToRoot", footRelativeToRoot_Element.Data.ToResoniteLinkField());
members.Add("footGroundHeight", footGroundHeight_Element.Data.ToResoniteLinkField());
}

}
            }
}

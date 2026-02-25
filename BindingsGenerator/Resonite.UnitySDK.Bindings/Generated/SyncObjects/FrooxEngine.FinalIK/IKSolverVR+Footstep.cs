
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FinalIK.IKSolverVR+Footstep
// Generated on: středa 25. února 2026 16:14:38
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
    public global::System.Boolean _initialized;
public UnityEngine.Quaternion footRelativeToRoot;
public global::System.Single footGroundHeight;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_initialized", _initialized.ToResoniteLinkField());
members.Add("footRelativeToRoot", footRelativeToRoot.ToResoniteLinkField());
members.Add("footGroundHeight", footGroundHeight.ToResoniteLinkField());
}

}
            }
}

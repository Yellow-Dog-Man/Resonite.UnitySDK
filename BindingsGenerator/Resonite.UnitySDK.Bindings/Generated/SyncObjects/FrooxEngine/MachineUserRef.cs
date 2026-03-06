
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MachineUserRef
// Generated on: pátek 6. března 2026 14:19:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MachineUserRef")]
public partial class MachineUserRef : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.User User { get => User_Element.Data; set => User_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.User>, global::FrooxEngine.User> User_Element = new();
public global::System.String _machineId { get => _machineId_Element.Data; set => _machineId_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> _machineId_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("User", User_Element.ToLinkReference(context));
members.Add("_machineId", _machineId_Element.ToLinkField(context));
}

}
}

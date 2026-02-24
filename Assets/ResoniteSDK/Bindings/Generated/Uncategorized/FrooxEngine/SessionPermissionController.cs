
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SessionPermissionController
// Generated on: úterý 24. února 2026 18:20:28
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SessionPermissionController")]
public partial class SessionPermissionController : global::FrooxEngine.Component

{
    public global::FrooxEngine.UIX.Text _name;
public System.Collections.Generic.List<global::FrooxEngine.UIX.Button> _rolesButtons;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_name", _name.ToResoniteReference(context));
members.Add("_rolesButtons", new ResoniteLink.SyncList()
{
    Elements = _rolesButtons.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}

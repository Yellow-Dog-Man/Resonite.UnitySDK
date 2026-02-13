
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SessionPermissionController
// Generated on: pátek 13. února 2026 5:52:36
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_name", new ResoniteLink.Reference() { });
members.Add("_rolesButtons", new ResoniteLink.SyncList()
{
    Elements = _rolesButtons.Select(m => new ResoniteLink.Reference() { }).ToList<ResoniteLink.Member>()
});
}

}
}

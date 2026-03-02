
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SessionPermissionController
// Generated on: pondělí 2. března 2026 17:53:36
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SessionPermissionController")]
public partial class SessionPermissionController : global::FrooxEngine.Component

{
    public global::FrooxEngine.UIX.Text _name { get => _name_Element.Data; set => _name_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _name_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button>> _rolesButtons = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_name", _name_Element.ToLinkReference(context));
members.Add("_rolesButtons", _rolesButtons.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}

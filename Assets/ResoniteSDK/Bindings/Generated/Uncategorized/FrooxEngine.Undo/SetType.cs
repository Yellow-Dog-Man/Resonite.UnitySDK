
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Undo.SetType
// Generated on: pátek 13. února 2026 23:23:18
// Resonite version: 2026.2.12.359
// Resonite Link Version: 0.7.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.Undo
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Undo.SetType")]
public partial class SetType : global::FrooxEngine.Component, global::FrooxEngine.Undo.IUndoable

{
    public global::FrooxEngine.SyncType Target;
public System.String ValueBefore;
public System.String ValueAfter;
public global::System.Boolean _performed;
public global::System.String _description;

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("Target", new ResoniteLink.Reference() { });
members.Add("ValueBefore", ValueBefore.ToResoniteLinkField());
members.Add("ValueAfter", ValueAfter.ToResoniteLinkField());
members.Add("_performed", _performed.ToResoniteLinkField());
members.Add("_description", _description.ToResoniteLinkField());
}

}
}

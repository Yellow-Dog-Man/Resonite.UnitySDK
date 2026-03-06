
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TestFakeViveTracker
// Generated on: pátek 6. března 2026 14:18:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TestFakeViveTracker")]
public partial class TestFakeViveTracker : global::FrooxEngine.Component

{
    public global::System.String Id { get => Id_Element.Data; set => Id_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> Id_Element = new();
public global::System.Boolean IsTracking { get => IsTracking_Element.Data; set => IsTracking_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsTracking_Element = new();
public global::FrooxEngine.UserRef User = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Id", Id_Element.ToLinkField(context));
members.Add("IsTracking", IsTracking_Element.ToLinkField(context));
members.Add("User", User.ToLinkSyncObject(context));
}

}
}

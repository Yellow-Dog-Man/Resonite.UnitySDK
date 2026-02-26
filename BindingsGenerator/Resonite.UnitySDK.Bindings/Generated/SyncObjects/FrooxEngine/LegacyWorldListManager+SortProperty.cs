
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyWorldListManager+SortProperty
// Generated on: čtvrtek 26. února 2026 12:28:02
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public partial class LegacyWorldListManager
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyWorldListManager+SortProperty")]
public partial class SortProperty : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.LegacyWorldListManager.SortParameter Parameter { get => Parameter_Element.Data; set => Parameter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.LegacyWorldListManager.SortParameter>, global::FrooxEngine.LegacyWorldListManager.SortParameter> Parameter_Element = new();
public global::FrooxEngine.LegacyWorldListManager.SortDirection Direction { get => Direction_Element.Data; set => Direction_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.LegacyWorldListManager.SortDirection>, global::FrooxEngine.LegacyWorldListManager.SortDirection> Direction_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Parameter", Parameter_Element.ToLinkField(context));
members.Add("Direction", Direction_Element.ToLinkField(context));
}

}
            }
}

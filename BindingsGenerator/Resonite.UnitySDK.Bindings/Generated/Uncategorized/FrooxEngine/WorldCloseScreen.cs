
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldCloseScreen
// Generated on: čtvrtek 26. února 2026 12:28:14
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
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldCloseScreen")]
public partial class WorldCloseScreen : global::FrooxEngine.RadiantDashScreen

{
    public global::FrooxEngine.WorldCloseDialog _closeDialog { get => _closeDialog_Element.Data; set => _closeDialog_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.WorldCloseDialog>, global::FrooxEngine.WorldCloseDialog> _closeDialog_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_closeDialog", _closeDialog_Element.ToLinkReference(context));
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ComponentCloneTool
// Generated on: sobota 14. února 2026 8:58:36
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ComponentCloneTool")]
public partial class ComponentCloneTool : global::FrooxEngine.BuilderActionTool

{
    public global::System.Boolean EnsureSingleInstance;
public global::System.Boolean AllowPickup;
public global::FrooxEngine.TextRenderer _label;
public global::FrooxEngine.Slot _templateRoot;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EnsureSingleInstance", EnsureSingleInstance.ToResoniteLinkField());
members.Add("AllowPickup", AllowPickup.ToResoniteLinkField());
members.Add("_label", _label.ToResoniteReference(context));
members.Add("_templateRoot", _templateRoot.ToResoniteReference(context));
}

}
}

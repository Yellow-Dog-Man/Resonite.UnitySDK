
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ComponentCloneTool
// Generated on: středa 25. února 2026 16:14:19
// Resonite version: 2026.2.25.455
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

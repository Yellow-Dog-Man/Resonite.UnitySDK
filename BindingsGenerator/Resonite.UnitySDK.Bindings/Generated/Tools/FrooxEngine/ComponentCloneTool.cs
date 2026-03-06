
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ComponentCloneTool
// Generated on: pátek 6. března 2026 14:19:05
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ComponentCloneTool")]
public partial class ComponentCloneTool : global::FrooxEngine.BuilderActionTool

{
    public global::System.Boolean EnsureSingleInstance { get => EnsureSingleInstance_Element.Data; set => EnsureSingleInstance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EnsureSingleInstance_Element = new();
public global::System.Boolean AllowPickup { get => AllowPickup_Element.Data; set => AllowPickup_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowPickup_Element = new();
public global::FrooxEngine.TextRenderer _label { get => _label_Element.Data; set => _label_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.TextRenderer>, global::FrooxEngine.TextRenderer> _label_Element = new();
public global::FrooxEngine.Slot _templateRoot { get => _templateRoot_Element.Data; set => _templateRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _templateRoot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EnsureSingleInstance", EnsureSingleInstance_Element.ToLinkField(context));
members.Add("AllowPickup", AllowPickup_Element.ToLinkField(context));
members.Add("_label", _label_Element.ToLinkReference(context));
members.Add("_templateRoot", _templateRoot_Element.ToLinkReference(context));
}

}
}

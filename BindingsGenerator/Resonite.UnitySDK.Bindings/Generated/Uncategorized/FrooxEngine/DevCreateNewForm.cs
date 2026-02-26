
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DevCreateNewForm
// Generated on: čtvrtek 26. února 2026 15:09:10
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DevCreateNewForm")]
public partial class DevCreateNewForm : global::FrooxEngine.Component, global::FrooxEngine.IDeveloperInterface

{
    public global::System.String CategoryRoot { get => CategoryRoot_Element.Data; set => CategoryRoot_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> CategoryRoot_Element = new();
public global::FrooxEngine.Slot _contentRoot { get => _contentRoot_Element.Data; set => _contentRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _contentRoot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CategoryRoot", CategoryRoot_Element.ToLinkField(context));
members.Add("_contentRoot", _contentRoot_Element.ToLinkReference(context));
}

}
}

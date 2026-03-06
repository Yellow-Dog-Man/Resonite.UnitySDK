
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GenericUIContainer
// Generated on: pátek 6. března 2026 14:18:06
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GenericUIContainer")]
public partial class GenericUIContainer : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<global::System.String> Title { get => Title_Element.Data; set => Title_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.String>>, global::FrooxEngine.IField<global::System.String>> Title_Element = new();
public global::System.Boolean CloseRequest { get => CloseRequest_Element.Data; set => CloseRequest_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> CloseRequest_Element = new();
public global::FrooxEngine.Slot CloseDestroyRoot { get => CloseDestroyRoot_Element.Data; set => CloseDestroyRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> CloseDestroyRoot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Title", Title_Element.ToLinkReference(context));
members.Add("CloseRequest", CloseRequest_Element.ToLinkField(context));
members.Add("CloseDestroyRoot", CloseDestroyRoot_Element.ToLinkReference(context));
}

}
}

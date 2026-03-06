
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ButtonParentUnderUser
// Generated on: pátek 6. března 2026 14:18:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ButtonParentUnderUser")]
public partial class ButtonParentUnderUser : global::FrooxEngine.Component, global::FrooxEngine.IButtonPressReceiver

{
    public global::FrooxEngine.Slot Root { get => Root_Element.Data; set => Root_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Root_Element = new();
public global::System.Boolean FindObjectRoot { get => FindObjectRoot_Element.Data; set => FindObjectRoot_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> FindObjectRoot_Element = new();
public global::System.Boolean UnparentWhenParented { get => UnparentWhenParented_Element.Data; set => UnparentWhenParented_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UnparentWhenParented_Element = new();
public global::System.Boolean PreserveOriginalSpace { get => PreserveOriginalSpace_Element.Data; set => PreserveOriginalSpace_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PreserveOriginalSpace_Element = new();
public global::FrooxEngine.Slot _originalSpace { get => _originalSpace_Element.Data; set => _originalSpace_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _originalSpace_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Root", Root_Element.ToLinkReference(context));
members.Add("FindObjectRoot", FindObjectRoot_Element.ToLinkField(context));
members.Add("UnparentWhenParented", UnparentWhenParented_Element.ToLinkField(context));
members.Add("PreserveOriginalSpace", PreserveOriginalSpace_Element.ToLinkField(context));
members.Add("_originalSpace", _originalSpace_Element.ToLinkReference(context));
}

}
}

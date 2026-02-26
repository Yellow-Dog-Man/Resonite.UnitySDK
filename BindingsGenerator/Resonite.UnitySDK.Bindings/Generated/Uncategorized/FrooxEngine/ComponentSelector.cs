
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ComponentSelector
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ComponentSelector")]
public partial class ComponentSelector : global::FrooxEngine.Component, global::FrooxEngine.IDeveloperInterface

{
    public global::FrooxEngine.Slot _uiRoot { get => _uiRoot_Element.Data; set => _uiRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _uiRoot_Element = new();
public global::System.String _rootPath { get => _rootPath_Element.Data; set => _rootPath_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> _rootPath_Element = new();
public System.String _genericType { get => _genericType_Element.Data; set => _genericType_Element.Data = value; }
public Field<global::FrooxEngine.SyncType, System.String> _genericType_Element = new();
public global::FrooxEngine.IField<global::System.String> _customGenericTypeLabel { get => _customGenericTypeLabel_Element.Data; set => _customGenericTypeLabel_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.String>, global::FrooxEngine.IField<global::System.String>> _customGenericTypeLabel_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> _customGenericTypeColor { get => _customGenericTypeColor_Element.Data; set => _customGenericTypeColor_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> _customGenericTypeColor_Element = new();
public global::SyncFieldList<global::FrooxEngine.SyncRefList<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField, Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField>> _customGenericArguments = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_uiRoot", _uiRoot_Element.ToLinkReference(context));
members.Add("_rootPath", _rootPath_Element.ToLinkField(context));
members.Add("_genericType", _genericType_Element.ToLinkField(context));
members.Add("_customGenericTypeLabel", _customGenericTypeLabel_Element.ToLinkReference(context));
members.Add("_customGenericTypeColor", _customGenericTypeColor_Element.ToLinkReference(context));
members.Add("_customGenericArguments", _customGenericArguments.ToLinkList(context, m => m.ToLinkReference(context)));
}

}
}

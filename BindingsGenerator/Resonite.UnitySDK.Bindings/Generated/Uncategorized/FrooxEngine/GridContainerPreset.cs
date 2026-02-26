
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GridContainerPreset
// Generated on: čtvrtek 26. února 2026 15:09:12
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GridContainerPreset")]
public partial class GridContainerPreset : global::FrooxEngine.Component, global::FrooxEngine.IModifiedEventReceiver

{
    public System.String _initializer { get => _initializer_Element.Data; set => _initializer_Element.Data = value; }
public Field<global::FrooxEngine.SyncType, System.String> _initializer_Element = new();
public global::System.Int32 _initializedVersion { get => _initializedVersion_Element.Data; set => _initializedVersion_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> _initializedVersion_Element = new();
public global::System.Boolean _isModified { get => _isModified_Element.Data; set => _isModified_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _isModified_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_initializer", _initializer_Element.ToLinkField(context));
members.Add("_initializedVersion", _initializedVersion_Element.ToLinkField(context));
members.Add("_isModified", _isModified_Element.ToLinkField(context));
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GridContainerPreset
// Generated on: sobota 14. února 2026 8:58:44
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GridContainerPreset")]
public partial class GridContainerPreset : global::FrooxEngine.Component, global::FrooxEngine.IModifiedEventReceiver

{
    public System.String _initializer;
public global::System.Int32 _initializedVersion;
public global::System.Boolean _isModified;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_initializer", _initializer.ToResoniteLinkField());
members.Add("_initializedVersion", _initializedVersion.ToResoniteLinkField());
members.Add("_isModified", _isModified.ToResoniteLinkField());
}

}
}

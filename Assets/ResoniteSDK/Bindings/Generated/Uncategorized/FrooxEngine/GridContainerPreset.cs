
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GridContainerPreset
// Generated on: pátek 13. února 2026 23:23:14
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_initializer", _initializer.ToResoniteLinkField());
members.Add("_initializedVersion", _initializedVersion.ToResoniteLinkField());
members.Add("_isModified", _isModified.ToResoniteLinkField());
}

}
}

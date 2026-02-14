
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ComponentSelector
// Generated on: sobota 14. února 2026 8:58:42
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ComponentSelector")]
public partial class ComponentSelector : global::FrooxEngine.Component, global::FrooxEngine.IDeveloperInterface

{
    public global::FrooxEngine.Slot _uiRoot;
public global::System.String _rootPath;
public System.String _genericType;
public global::FrooxEngine.IField<global::System.String> _customGenericTypeLabel;
public global::FrooxEngine.IField<UnityEngine.ColorX> _customGenericTypeColor;
public System.Collections.Generic.List<global::FrooxEngine.UIX.TextField> _customGenericArguments;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_uiRoot", _uiRoot.ToResoniteReference(context));
members.Add("_rootPath", _rootPath.ToResoniteLinkField());
members.Add("_genericType", _genericType.ToResoniteLinkField());
members.Add("_customGenericTypeLabel", _customGenericTypeLabel.ToResoniteReference(context));
members.Add("_customGenericTypeColor", _customGenericTypeColor.ToResoniteReference(context));
members.Add("_customGenericArguments", new ResoniteLink.SyncList()
{
    Elements = _customGenericArguments.ConvertList(m => m.ToResoniteReference(context))
});
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SceneInspector
// Generated on: čtvrtek 19. února 2026 8:00:30
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SceneInspector")]
public partial class SceneInspector : global::FrooxEngine.InspectorPanel, global::FrooxEngine.Undo.INoDestroyUndo, global::FrooxEngine.IObjectRoot

{
    public global::FrooxEngine.Slot Root;
public global::FrooxEngine.Slot ComponentView;
public global::FrooxEngine.Sync<global::System.String> _rootText;
public global::FrooxEngine.Sync<global::System.String> _componentText;
public global::FrooxEngine.Slot _hierarchyContentRoot;
public global::FrooxEngine.Slot _componentsContentRoot;
public global::FrooxEngine.Slot _currentComponent;
public global::FrooxEngine.Slot _currentRoot;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Root", Root.ToResoniteReference(context));
members.Add("ComponentView", ComponentView.ToResoniteReference(context));
members.Add("_rootText", _rootText.ToResoniteReference(context));
members.Add("_componentText", _componentText.ToResoniteReference(context));
members.Add("_hierarchyContentRoot", _hierarchyContentRoot.ToResoniteReference(context));
members.Add("_componentsContentRoot", _componentsContentRoot.ToResoniteReference(context));
members.Add("_currentComponent", _currentComponent.ToResoniteReference(context));
members.Add("_currentRoot", _currentRoot.ToResoniteReference(context));
}

}
}

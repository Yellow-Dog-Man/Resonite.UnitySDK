
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.SceneInspector
// Generated on: čtvrtek 26. února 2026 15:09:14
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.SceneInspector")]
public partial class SceneInspector : global::FrooxEngine.InspectorPanel, global::FrooxEngine.Undo.INoDestroyUndo, global::FrooxEngine.IObjectRoot

{
    public global::FrooxEngine.Slot Root { get => Root_Element.Data; set => Root_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> Root_Element = new();
public global::FrooxEngine.Slot ComponentView { get => ComponentView_Element.Data; set => ComponentView_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> ComponentView_Element = new();
public global::FrooxEngine.Sync<global::System.String> _rootText { get => _rootText_Element.Data; set => _rootText_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Sync<global::System.String>>, global::FrooxEngine.Sync<global::System.String>> _rootText_Element = new();
public global::FrooxEngine.Sync<global::System.String> _componentText { get => _componentText_Element.Data; set => _componentText_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Sync<global::System.String>>, global::FrooxEngine.Sync<global::System.String>> _componentText_Element = new();
public global::FrooxEngine.Slot _hierarchyContentRoot { get => _hierarchyContentRoot_Element.Data; set => _hierarchyContentRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _hierarchyContentRoot_Element = new();
public global::FrooxEngine.Slot _componentsContentRoot { get => _componentsContentRoot_Element.Data; set => _componentsContentRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _componentsContentRoot_Element = new();
public global::FrooxEngine.Slot _currentComponent { get => _currentComponent_Element.Data; set => _currentComponent_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _currentComponent_Element = new();
public global::FrooxEngine.Slot _currentRoot { get => _currentRoot_Element.Data; set => _currentRoot_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _currentRoot_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Root", Root_Element.ToLinkReference(context));
members.Add("ComponentView", ComponentView_Element.ToLinkReference(context));
members.Add("_rootText", _rootText_Element.ToLinkReference(context));
members.Add("_componentText", _componentText_Element.ToLinkReference(context));
members.Add("_hierarchyContentRoot", _hierarchyContentRoot_Element.ToLinkReference(context));
members.Add("_componentsContentRoot", _componentsContentRoot_Element.ToLinkReference(context));
members.Add("_currentComponent", _currentComponent_Element.ToLinkReference(context));
members.Add("_currentRoot", _currentRoot_Element.ToLinkReference(context));
}

}
}

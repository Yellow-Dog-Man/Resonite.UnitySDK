
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Undo.SpawnOrDestroy
// Generated on: čtvrtek 26. února 2026 12:28:13
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine.Undo
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Undo.SpawnOrDestroy")]
public partial class SpawnOrDestroy : global::FrooxEngine.Component, global::FrooxEngine.Undo.IUndoable

{
    public global::FrooxEngine.Worker Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Worker>, global::FrooxEngine.Worker> Target_Element = new();
public global::FrooxEngine.Slot TargetParent { get => TargetParent_Element.Data; set => TargetParent_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> TargetParent_Element = new();
public global::FrooxEngine.Undo.SpawnOrDestroy.Mode _mode { get => _mode_Element.Data; set => _mode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Undo.SpawnOrDestroy.Mode>, global::FrooxEngine.Undo.SpawnOrDestroy.Mode> _mode_Element = new();
public global::System.Boolean _preserveAssets { get => _preserveAssets_Element.Data; set => _preserveAssets_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _preserveAssets_Element = new();
public global::System.Boolean _sendDestroyingEvents { get => _sendDestroyingEvents_Element.Data; set => _sendDestroyingEvents_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _sendDestroyingEvents_Element = new();
public System.Uri _savedObject { get => _savedObject_Element.Data; set => _savedObject_Element.Data = value; }
public Field<global::FrooxEngine.Sync<System.Uri>, System.Uri> _savedObject_Element = new();
public global::System.Boolean _isComponent { get => _isComponent_Element.Data; set => _isComponent_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _isComponent_Element = new();
public global::FrooxEngine.SavedReferenceTable _referenceTable { get => _referenceTable_Element.Data; set => _referenceTable_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SavedReferenceTable>, global::FrooxEngine.SavedReferenceTable> _referenceTable_Element = new();
public global::System.Boolean _isSaving { get => _isSaving_Element.Data; set => _isSaving_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _isSaving_Element = new();
public global::System.String _description { get => _description_Element.Data; set => _description_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> _description_Element = new();
public global::System.Boolean _performed { get => _performed_Element.Data; set => _performed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _performed_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("TargetParent", TargetParent_Element.ToLinkReference(context));
members.Add("_mode", _mode_Element.ToLinkField(context));
members.Add("_preserveAssets", _preserveAssets_Element.ToLinkField(context));
members.Add("_sendDestroyingEvents", _sendDestroyingEvents_Element.ToLinkField(context));
members.Add("_savedObject", _savedObject_Element.ToLinkField(context));
members.Add("_isComponent", _isComponent_Element.ToLinkField(context));
members.Add("_referenceTable", _referenceTable_Element.ToLinkReference(context));
members.Add("_isSaving", _isSaving_Element.ToLinkField(context));
members.Add("_description", _description_Element.ToLinkField(context));
members.Add("_performed", _performed_Element.ToLinkField(context));
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Undo.AddRemoveListElement<>
// Generated on: čtvrtek 26. února 2026 12:28:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Undo.AddRemoveListElement<>")]
public partial class AddRemoveListElement<T> : global::FrooxEngine.Component, global::FrooxEngine.Undo.IUndoable
	where T : class, global::FrooxEngine.ISyncMember

{
    public global::FrooxEngine.SyncList<T> TargetList { get => TargetList_Element.Data; set => TargetList_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SyncList<T>>, global::FrooxEngine.SyncList<T>> TargetList_Element = new();
public T TargetElement { get => TargetElement_Element.Data; set => TargetElement_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<T>, T> TargetElement_Element = new();
public global::System.String _description { get => _description_Element.Data; set => _description_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> _description_Element = new();
public System.Uri _savedObject { get => _savedObject_Element.Data; set => _savedObject_Element.Data = value; }
public Field<global::FrooxEngine.Sync<System.Uri>, System.Uri> _savedObject_Element = new();
public global::FrooxEngine.SavedReferenceTable _referenceTable { get => _referenceTable_Element.Data; set => _referenceTable_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.SavedReferenceTable>, global::FrooxEngine.SavedReferenceTable> _referenceTable_Element = new();
public global::System.Boolean _isSaving { get => _isSaving_Element.Data; set => _isSaving_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _isSaving_Element = new();
public global::FrooxEngine.Undo.AddRemoveListElement<T>.Mode _mode { get => _mode_Element.Data; set => _mode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.Undo.AddRemoveListElement<T>.Mode>, global::FrooxEngine.Undo.AddRemoveListElement<T>.Mode> _mode_Element = new();
public global::System.Boolean _performed { get => _performed_Element.Data; set => _performed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> _performed_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetList", TargetList_Element.ToLinkReference(context));
members.Add("TargetElement", TargetElement_Element.ToLinkReference(context));
members.Add("_description", _description_Element.ToLinkField(context));
members.Add("_savedObject", _savedObject_Element.ToLinkField(context));
members.Add("_referenceTable", _referenceTable_Element.ToLinkReference(context));
members.Add("_isSaving", _isSaving_Element.ToLinkField(context));
members.Add("_mode", _mode_Element.ToLinkField(context));
members.Add("_performed", _performed_Element.ToLinkField(context));
}

}
}

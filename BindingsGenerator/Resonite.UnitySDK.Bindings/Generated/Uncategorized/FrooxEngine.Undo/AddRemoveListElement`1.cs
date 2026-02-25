
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Undo.AddRemoveListElement<>
// Generated on: středa 25. února 2026 16:14:34
// Resonite version: 2026.2.25.455
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
    public global::FrooxEngine.SyncList<T> TargetList;
public T TargetElement;
public global::System.String _description;
public System.Uri _savedObject;
public global::FrooxEngine.SavedReferenceTable _referenceTable;
public global::System.Boolean _isSaving;
public global::FrooxEngine.Undo.AddRemoveListElement<T>.Mode _mode;
public global::System.Boolean _performed;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("TargetList", TargetList.ToResoniteReference(context));
members.Add("TargetElement", TargetElement.ToResoniteReference(context));
members.Add("_description", _description.ToResoniteLinkField());
members.Add("_savedObject", _savedObject.ToResoniteLinkField());
members.Add("_referenceTable", _referenceTable.ToResoniteReference(context));
members.Add("_isSaving", _isSaving.ToResoniteLinkField());
members.Add("_mode", _mode.ToResoniteLinkField());
members.Add("_performed", _performed.ToResoniteLinkField());
}

}
}

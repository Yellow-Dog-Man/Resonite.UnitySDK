
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ExportDialog
// Generated on: sobota 14. února 2026 8:58:43
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ExportDialog")]
public partial class ExportDialog : global::FrooxEngine.Component

{
    public global::System.Int32 SelectedExportOption;
public global::FrooxEngine.UIX.TextField ExportName;
public global::System.String _targetFolder;
public global::System.Boolean EditEnabled;
public global::FrooxEngine.UIX.Button _cancel;
public global::FrooxEngine.UIX.Button _export;
public System.Collections.Generic.List<global::FrooxEngine.ExportDialog.ExportOption> _exportOptions;
public global::FrooxEngine.IField FileName;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SelectedExportOption", SelectedExportOption.ToResoniteLinkField());
members.Add("ExportName", ExportName.ToResoniteReference(context));
members.Add("_targetFolder", _targetFolder.ToResoniteLinkField());
members.Add("EditEnabled", EditEnabled.ToResoniteLinkField());
members.Add("_cancel", _cancel.ToResoniteReference(context));
members.Add("_export", _export.ToResoniteReference(context));
members.Add("_exportOptions", new ResoniteLink.SyncList()
{
    Elements = _exportOptions.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("FileName", FileName.ToResoniteReference(context));
}

}
}

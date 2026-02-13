
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ExportDialog
// Generated on: pátek 13. února 2026 5:52:30
// Resonite version: 2026.2.13.254
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("SelectedExportOption", SelectedExportOption.ToResoniteLinkField());
members.Add("ExportName", new ResoniteLink.Reference() { });
members.Add("_targetFolder", _targetFolder.ToResoniteLinkField());
members.Add("EditEnabled", EditEnabled.ToResoniteLinkField());
members.Add("_cancel", new ResoniteLink.Reference() { });
members.Add("_export", new ResoniteLink.Reference() { });
members.Add("_exportOptions", new ResoniteLink.SyncList()
{
    Elements = _exportOptions.Select(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers() }).ToList<ResoniteLink.Member>()
});
members.Add("FileName", new ResoniteLink.Reference() { });
}

}
}

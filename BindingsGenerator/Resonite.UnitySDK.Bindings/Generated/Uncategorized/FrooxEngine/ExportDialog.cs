
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ExportDialog
// Generated on: čtvrtek 26. února 2026 10:04:44
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
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
    public global::System.Int32 SelectedExportOption { get => SelectedExportOption_Element.Data; set => SelectedExportOption_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> SelectedExportOption_Element = new();
public global::FrooxEngine.UIX.TextField ExportName { get => ExportName_Element.Data; set => ExportName_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> ExportName_Element = new();
public global::System.String _targetFolder { get => _targetFolder_Element.Data; set => _targetFolder_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.String>, global::System.String> _targetFolder_Element = new();
public global::System.Boolean EditEnabled { get => EditEnabled_Element.Data; set => EditEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EditEnabled_Element = new();
public global::FrooxEngine.UIX.Button _cancel { get => _cancel_Element.Data; set => _cancel_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _cancel_Element = new();
public global::FrooxEngine.UIX.Button _export { get => _export_Element.Data; set => _export_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Button>, global::FrooxEngine.UIX.Button> _export_Element = new();
public global::SyncList<global::FrooxEngine.SyncList<global::FrooxEngine.ExportDialog.ExportOption>, global::FrooxEngine.ExportDialog.ExportOption> _exportOptions = new();
public global::FrooxEngine.IField FileName { get => FileName_Element.Data; set => FileName_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField>, global::FrooxEngine.IField> FileName_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SelectedExportOption", SelectedExportOption_Element.Data.ToResoniteLinkField());
members.Add("ExportName", ExportName_Element.Data.ToResoniteReference(context));
members.Add("_targetFolder", _targetFolder_Element.Data.ToResoniteLinkField());
members.Add("EditEnabled", EditEnabled_Element.Data.ToResoniteLinkField());
members.Add("_cancel", _cancel_Element.Data.ToResoniteReference(context));
members.Add("_export", _export_Element.Data.ToResoniteReference(context));
members.Add("_exportOptions", new ResoniteLink.SyncList()
{
    Elements = _exportOptions.Data.ConvertList(m => new ResoniteLink.SyncObject() { Members = m.CollectMembers(context) })
});
members.Add("FileName", FileName_Element.Data.ToResoniteReference(context));
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ExportDialog+ExportOption
// Generated on: čtvrtek 26. února 2026 12:28:10
// Resonite version: 2026.2.26.702
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    public partial class ExportDialog
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ExportDialog+ExportOption")]
public partial class ExportOption : global::FrooxEngine.SyncObject

{
    public global::FrooxEngine.IExportable Exportable { get => Exportable_Element.Data; set => Exportable_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.IExportable>, global::FrooxEngine.IExportable> Exportable_Element = new();
public global::System.Int32 ExportType { get => ExportType_Element.Data; set => ExportType_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> ExportType_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Exportable", Exportable_Element.ToLinkReference(context));
members.Add("ExportType", ExportType_Element.ToLinkField(context));
}

}
            }
}

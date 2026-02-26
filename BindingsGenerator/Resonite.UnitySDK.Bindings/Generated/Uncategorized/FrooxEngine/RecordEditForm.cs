
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RecordEditForm
// Generated on: čtvrtek 26. února 2026 10:04:47
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RecordEditForm")]
public partial class RecordEditForm : global::FrooxEngine.Component

{
    public global::FrooxEngine.WorldOrb _worldOrb { get => _worldOrb_Element.Data; set => _worldOrb_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.WorldOrb>, global::FrooxEngine.WorldOrb> _worldOrb_Element = new();
public global::FrooxEngine.UIX.TextField _name { get => _name_Element.Data; set => _name_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _name_Element = new();
public global::FrooxEngine.UIX.TextField _description { get => _description_Element.Data; set => _description_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _description_Element = new();
public global::FrooxEngine.UIX.TextField _path { get => _path_Element.Data; set => _path_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _path_Element = new();
public global::FrooxEngine.UIX.TextField _tags { get => _tags_Element.Data; set => _tags_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.TextField>, global::FrooxEngine.UIX.TextField> _tags_Element = new();
public global::FrooxEngine.RecordEditForm.PublicSetting _publicSetting { get => _publicSetting_Element.Data; set => _publicSetting_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.RecordEditForm.PublicSetting>, global::FrooxEngine.RecordEditForm.PublicSetting> _publicSetting_Element = new();
public global::FrooxEngine.UIX.Checkbox _readonly { get => _readonly_Element.Data; set => _readonly_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Checkbox>, global::FrooxEngine.UIX.Checkbox> _readonly_Element = new();
public global::FrooxEngine.UserRef _ownerUser = new();
public global::FrooxEngine.UIX.Text _privateOptionText { get => _privateOptionText_Element.Data; set => _privateOptionText_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.UIX.Text>, global::FrooxEngine.UIX.Text> _privateOptionText_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_worldOrb", _worldOrb_Element.Data.ToResoniteReference(context));
members.Add("_name", _name_Element.Data.ToResoniteReference(context));
members.Add("_description", _description_Element.Data.ToResoniteReference(context));
members.Add("_path", _path_Element.Data.ToResoniteReference(context));
members.Add("_tags", _tags_Element.Data.ToResoniteReference(context));
members.Add("_publicSetting", _publicSetting_Element.Data.ToResoniteLinkField());
members.Add("_readonly", _readonly_Element.Data.ToResoniteReference(context));
members.Add("_ownerUser", new ResoniteLink.SyncObject() { Members = _ownerUser.CollectMembers(context) });
members.Add("_privateOptionText", _privateOptionText_Element.Data.ToResoniteReference(context));
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.RecordEditForm
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.RecordEditForm")]
public partial class RecordEditForm : global::FrooxEngine.Component

{
    public global::FrooxEngine.WorldOrb _worldOrb;
public global::FrooxEngine.UIX.TextField _name;
public global::FrooxEngine.UIX.TextField _description;
public global::FrooxEngine.UIX.TextField _path;
public global::FrooxEngine.UIX.TextField _tags;
public global::FrooxEngine.RecordEditForm.PublicSetting _publicSetting;
public global::FrooxEngine.UIX.Checkbox _readonly;
public global::FrooxEngine.UserRef _ownerUser;
public global::FrooxEngine.UIX.Text _privateOptionText;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_worldOrb", _worldOrb.ToResoniteReference(context));
members.Add("_name", _name.ToResoniteReference(context));
members.Add("_description", _description.ToResoniteReference(context));
members.Add("_path", _path.ToResoniteReference(context));
members.Add("_tags", _tags.ToResoniteReference(context));
members.Add("_publicSetting", _publicSetting.ToResoniteLinkField());
members.Add("_readonly", _readonly.ToResoniteReference(context));
members.Add("_ownerUser", new ResoniteLink.SyncObject() { Members = _ownerUser.CollectMembers(context) });
members.Add("_privateOptionText", _privateOptionText.ToResoniteReference(context));
}

}
}


// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FileBrowser
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.FileBrowser")]
public partial class FileBrowser : global::FrooxEngine.BrowserDialog

{
    public global::System.String CurrentPath;
public global::System.String _lastPath;
public global::FrooxEngine.MachineUserRef _user;
public global::FrooxEngine.UIX.Button _importButton;
public global::FrooxEngine.UIX.Button _rawImportButton;
public global::FrooxEngine.UIX.Button _createNewButton;
public global::FrooxEngine.UIX.Button _reloadButton;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("CurrentPath", CurrentPath.ToResoniteLinkField());
members.Add("_lastPath", _lastPath.ToResoniteLinkField());
members.Add("_user", new ResoniteLink.SyncObject() { Members = _user.CollectMembers(context) });
members.Add("_importButton", _importButton.ToResoniteReference(context));
members.Add("_rawImportButton", _rawImportButton.ToResoniteReference(context));
members.Add("_createNewButton", _createNewButton.ToResoniteReference(context));
members.Add("_reloadButton", _reloadButton.ToResoniteReference(context));
}

}
}

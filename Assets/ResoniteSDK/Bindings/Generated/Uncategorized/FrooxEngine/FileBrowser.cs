
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.FileBrowser
// Generated on: pátek 13. února 2026 5:52:31
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("CurrentPath", CurrentPath.ToResoniteLinkField());
members.Add("_lastPath", _lastPath.ToResoniteLinkField());
members.Add("_user", new ResoniteLink.SyncObject() { Members = _user.CollectMembers() });
members.Add("_importButton", new ResoniteLink.Reference() { });
members.Add("_rawImportButton", new ResoniteLink.Reference() { });
members.Add("_createNewButton", new ResoniteLink.Reference() { });
members.Add("_reloadButton", new ResoniteLink.Reference() { });
}

}
}

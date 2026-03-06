
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DocumentInterface
// Generated on: pátek 6. března 2026 14:19:12
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DocumentInterface")]
public partial class DocumentInterface : global::FrooxEngine.EntityInterface

{
    public global::FrooxEngine.IField<System.Uri> URL { get => URL_Element.Data; set => URL_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<System.Uri>>, global::FrooxEngine.IField<System.Uri>> URL_Element = new();
public global::FrooxEngine.IField<global::System.Int32> Page { get => Page_Element.Data; set => Page_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.IField<global::System.Int32>>, global::FrooxEngine.IField<global::System.Int32>> Page_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("URL", URL_Element.ToLinkReference(context));
members.Add("Page", Page_Element.ToLinkReference(context));
}

}
}

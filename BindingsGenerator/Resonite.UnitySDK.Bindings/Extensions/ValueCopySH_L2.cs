using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FrooxEngine;
using Elements.Core;

namespace FrooxEngine
{
    // This variant is needed to copy SH2 values for skybox and ambient lighting
    // Currently the system doesn't properly handle generic arguments, so we use this approach
    // TODO!!! Replace this with a proper generic approach? Constructing the type name dynamically.
    [ResoniteTypeName("[FrooxEngine]FrooxEngine.ValueCopy<[Elements.Core]Elements.Core.SphericalHarmonicsL2<[Elements.Core]Elements.Core.colorX>>")]
    public class ValueCopySH_L2 : ValueCopy<UnityEngine.Rendering.SphericalHarmonicsL2>
    {
    }
}
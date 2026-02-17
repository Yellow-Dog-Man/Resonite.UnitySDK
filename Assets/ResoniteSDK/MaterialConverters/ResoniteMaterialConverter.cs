using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public abstract class ResoniteMaterialConverter : MonoBehaviour
{
    public const string HEURISTIC_METHOD_NAME = "EvaluateHeuristicConversion";

    public abstract FrooxEngine.IAssetProvider<FrooxEngine.Material>
        UpdateConversion(UnityEngine.Material material, IConversionContext context);
}

using UnityEngine;

[ExecuteInEditMode]
public abstract class ResoniteMaterialConverter : MonoBehaviour
{
    public const string HEURISTIC_METHOD_NAME = "EvaluateHeuristicConversion";

    public UnityEngine.Material Source;

    public abstract FrooxEngine.IAssetProvider<FrooxEngine.Material>
        UpdateConversion(UnityEngine.Material material, IConversionContext context);
}

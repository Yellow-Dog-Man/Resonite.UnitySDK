using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;

public class MaterialConverterAttribute : Attribute
{
    /// <summary>
    /// List of explicitly supported shaders by this converter.
    /// These are matched by the shader name including its full path.
    /// </summary>
    public IReadOnlyList<string> SupportedShaders { get; private set; }

    /// <summary>
    /// Indicates if the converter supports heuristics for determining if it can convert a material.
    /// This is invoked as a fallback when there's no directly supported shader.
    /// When true, the converter must implement a static method with the signature of 
    /// MaterialConversionHeuristicEvaluator that will be called.
    /// </summary>
    public bool SupportsHeuristics { get; private set; }

    public MaterialConverterAttribute(bool supportsHeuristics, params string[] supportedShaders)
    {
        this.SupportsHeuristics = supportsHeuristics;
        this.SupportedShaders = supportedShaders.ToList();
    }
}

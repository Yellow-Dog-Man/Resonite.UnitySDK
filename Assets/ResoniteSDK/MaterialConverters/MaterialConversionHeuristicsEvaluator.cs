using System;

/// <summary>
/// Determines if given material converter can conver given material and how confident it is in the conversion.
/// The system will use converter with the highest confidence rate.
/// </summary>
/// <param name="material">Material to be converted.</param>
/// <returns>Null if it's not able to convert it at all
/// Otherwise a score of confidence. Higher value indicates higher confidence.</returns>
public delegate float? MaterialConversionHeuristicEvaluator(UnityEngine.Material material);
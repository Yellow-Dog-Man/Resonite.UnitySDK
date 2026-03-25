using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Tracks all components and GameObjects added by the Resonite Avatar Setup Wizard
/// so they can be cleanly reverted. Lives on the avatar root GameObject.
/// </summary>
public class AvatarSetupTracker : MonoBehaviour
{
    [SerializeField] List<Component> _addedComponents = new List<Component>();
    [SerializeField] List<GameObject> _createdGameObjects = new List<GameObject>();
    [SerializeField] List<ExpressionMapping> _expressionMappings = new List<ExpressionMapping>();

    public IReadOnlyList<Component> AddedComponents => _addedComponents;
    public IReadOnlyList<GameObject> CreatedGameObjects => _createdGameObjects;
    public IReadOnlyList<ExpressionMapping> ExpressionMappings => _expressionMappings;

    public bool HasTrackedItems => _addedComponents.Count > 0 || _createdGameObjects.Count > 0;

    public void TrackComponent(Component c)
    {
        if (c != null && !_addedComponents.Contains(c))
            _addedComponents.Add(c);
    }

    public void TrackGameObject(GameObject go)
    {
        if (go != null && !_createdGameObjects.Contains(go))
            _createdGameObjects.Add(go);
    }

    public void SetExpressionMappings(List<ExpressionMapping> mappings)
    {
        _expressionMappings = mappings != null ? new List<ExpressionMapping>(mappings) : new List<ExpressionMapping>();
    }

    public void ClearTracking()
    {
        _addedComponents.Clear();
        _createdGameObjects.Clear();
    }

    [System.Serializable]
    public class ExpressionMapping
    {
        public SkinnedMeshRenderer Renderer;
        public int BlendshapeIndex;
        public string ExpressionName;
    }
}

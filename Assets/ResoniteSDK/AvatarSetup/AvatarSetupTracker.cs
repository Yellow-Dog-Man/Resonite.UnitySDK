using System.Collections.Generic;
using UnityEngine;

public class AvatarSetupTracker : MonoBehaviour
{
    [SerializeField] List<Component> _addedComponents = new List<Component>();
    [SerializeField] List<GameObject> _createdGameObjects = new List<GameObject>();

    public IReadOnlyList<Component> AddedComponents => _addedComponents;
    public IReadOnlyList<GameObject> CreatedGameObjects => _createdGameObjects;

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

    public void ClearTracking()
    {
        _addedComponents.Clear();
        _createdGameObjects.Clear();
    }
}

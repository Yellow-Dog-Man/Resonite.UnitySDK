using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ResoniteComponent), true)]
public class ComponentEditor : Editor
{
    public override void OnInspectorGUI()
    {
        // Update the displayed serialized data if it has changed
        serializedObject.UpdateIfRequiredOrScript();

        // Iterate the children of "Data"
        SerializedProperty iterator = serializedObject.FindProperty("Data");

        if (iterator == null)
            return;

        // TODO!!! Make this nicer. Just quick and dirty header label
        var headerStyle = new GUIStyle(EditorStyles.boldLabel)
        {
            fontSize = 16,
            alignment = TextAnchor.MiddleLeft,
            margin = new RectOffset(4, 4, 10, 4)
        };

        EditorGUILayout.LabelField(iterator.managedReferenceValue?.GetType().Name, headerStyle);

        // Start drawing the children properties of Data
        bool enterChildren = true;

        // Iterate over each child and draw it
        while (iterator.NextVisible(enterChildren))
        {
            // Draw the property field
            EditorGUILayout.PropertyField(iterator, true);
            // Prevent from iterating children of children of data
            enterChildren = false;
        }

        // Apply any modified values from this draw
        serializedObject.ApplyModifiedProperties();
    }
}
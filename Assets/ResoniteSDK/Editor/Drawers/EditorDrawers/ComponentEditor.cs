using UnityEditor;

[CustomEditor(typeof(ResoniteComponent<>), true)]
public class ComponentEditor : Editor
{
    public override void OnInspectorGUI()
    {
        // Update the displayed serialized data if it has changed
        serializedObject.UpdateIfRequiredOrScript();

        // Iterate the children of "Data"
        SerializedProperty iterator = serializedObject.FindProperty("Data");

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
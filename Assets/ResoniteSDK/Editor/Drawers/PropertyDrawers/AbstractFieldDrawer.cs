using UnityEngine;
using UnityEditor;

public abstract class AbstractFieldDrawer : PropertyDrawer
{

    /// <summary>
    /// The relative property path to the nested Data property
    /// </summary>
    /// <remarks>
    /// For example Field has "Data" and Reference has "_data"
    /// </remarks>
    protected abstract string DataPropertyName { get; }
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        SerializedProperty dataProperty = property.FindPropertyRelative(DataPropertyName);
        
        // Get the raw field name without _Element
        label.text = GetElementNiceName(property);

        if (dataProperty != null)
        {
            // Call the implemented draw field method
            DrawField(position, dataProperty, label, property);
        }
        // The data property is null if unity is unable to serialize that field type
        else
        {
            //Debug.LogWarning($"Field {property.name} of type {property.type} is unserializable in unity.");
            EditorGUI.LabelField(position, label, new GUIContent("Unserializable type"));
        }
    }

    /// <summary>
    /// Drop _Element from resonite field names.
    /// </summary>
    /// <param name="property">The property to get the name of.</param>
    /// <returns>Resonite-like field names.</returns>
    public static string GetElementNiceName(SerializedProperty property)
    {
        const string suffix = "_Element";

        // Get the actual name instead of the unity DisplayName
        string text = property.name;

        // If it ends with _Element (it should) then we remove that suffix
        if (text.EndsWith(suffix))
        {
            return text[..^suffix.Length];
        }

        return text;
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        SerializedProperty dataProperty = property.FindPropertyRelative(DataPropertyName);
        
        // Catch unserialized data property and return the default line height
        if (dataProperty == null) {
            return EditorGUIUtility.singleLineHeight;
        }
        
        // Return the line height for that property type
        return EditorGUI.GetPropertyHeight(dataProperty, true);
    }

    /// <summary>
    /// The implemented field drawer for the data property.
    /// </summary>
    /// <inheritdoc cref="OnGUI(Rect, SerializedProperty, GUIContent)"/>
    /// <param name="dataProperty">The nested data property field.</param>
    /// <param name="originalProperty">The base property field.</param>
    /// <returns>If this method has successfully drawn a field.</returns>
    protected abstract bool DrawField(Rect position, SerializedProperty dataProperty, GUIContent label, SerializedProperty originalProperty);
}
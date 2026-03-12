using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(Reference<,>), true)]
public class ReferenceDrawer : AbstractFieldDrawer
{
    protected override string DataPropertyName => "_data";

    protected override bool DrawField(Rect position, SerializedProperty dataProperty, GUIContent label, SerializedProperty originalProperty)
    {
        // originalProperty.GetUnderlyingType() -> Gets the field's Reference<TReference, TData> type
        
        // Temporary label field while there is no GUI for references
        EditorGUI.LabelField(position, label, new GUIContent("No GUI Implemented"));

        // This 'field' will always draw so we always return true
        return true;
    }
}

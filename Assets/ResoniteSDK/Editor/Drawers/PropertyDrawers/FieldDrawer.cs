using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(Field<,>), true)]
public class FieldDrawer : AbstractFieldDrawer
{
    protected override string DataPropertyName => "Data";

    protected override bool DrawField(Rect position, SerializedProperty dataProperty, GUIContent label, SerializedProperty originalProperty)
    {
        return EditorGUI.PropertyField(position, dataProperty, label, true);
    }
}

using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(SyncList<,>), true)]
public class SyncListDrawer : AbstractFieldDrawer
{
    protected override string DataPropertyName => "Data";

    protected override bool DrawField(Rect position, SerializedProperty dataProperty, GUIContent label, SerializedProperty originalProperty)
    {
        return EditorGUI.PropertyField(position, dataProperty, label);
    }
}

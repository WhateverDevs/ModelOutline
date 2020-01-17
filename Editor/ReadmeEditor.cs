using UnityEditor;

namespace Packages.ModelOutline.Editor
{
    /// <summary>
    /// Custom editor for the readme asset.
    /// </summary>
    [CustomEditor(typeof(Readme))]
    public class ReadmeEditor : UnityEditor.Editor
    {
        /// <summary>
        /// Paint the UI.
        /// </summary>
        public override void OnInspectorGUI()
        {
            EditorGUILayout.LabelField("This package provides a simple outline using a custom forward renderer");
            EditorGUILayout.LabelField("with additional render features.");
            EditorGUILayout.LabelField("By default it draws an outline on the objects that are on layer 8. We usually call it \"Outline\".");
            EditorGUILayout.LabelField("You can either use the custom renderer or create one of your own copying");
            EditorGUILayout.LabelField("the one provided so that you can modify it.");
            EditorGUILayout.LabelField("Doing this will also allow you yo change the material for the outline,");
            EditorGUILayout.LabelField("choosing a different color or width.");
        }
    }
}
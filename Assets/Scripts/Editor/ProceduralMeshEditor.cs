
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ProceduralMesh)), CanEditMultipleObjects]

public class ProceduralMeshEditor : Editor
{

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();


        ProceduralMesh script = (ProceduralMesh)target;
        if (GUILayout.Button("Generate Mesh"))
        {
            script.MeshStuff();
        }
        if (GUILayout.Button("Delete Mesh"))
        {
            script.DeleteMesh();
        }

    }
}

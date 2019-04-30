
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class ProceduralMesh : MonoBehaviour
{

    Mesh mesh;

    Vector3[] vertices;
    int[] triangles;

    public void MeshStuff ()
    {
        mesh = GetComponent<MeshFilter>().mesh;
        CalculateMeshData();
        CreateMesh();

    }

    public void DeleteMesh ()
    {
        mesh.Clear();
    }

    void CalculateMeshData() 
    {
        vertices = new Vector3[]{
            new Vector3(0.1f, 0, 0.1f), 
            new Vector3(0.1f, 0, 0.9f), 
            new Vector3(0.9f, 0, 0.1f),
            new Vector3(0.9f, 0, 0.9f),
            new Vector3(0.5f, 0.8f, 0.5f)

        };
        triangles = new int[] { 0, 1, 2, 2, 1, 3, 3, 2, 4, 4, 2, 0, 0, 1, 4, 4, 1, 3 };
    }

    void CreateMesh()
    {
        DeleteMesh();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
    }
}

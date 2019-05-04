using PathCreation;
using UnityEngine;

public class WaveSystem : MonoBehaviour
{
    public PathCreator pathCreator;
    public float firstCubePositionOffset;
    public int positionIncrement = 2;
    public GameObject cube;
 

    // Start is called before the first frame update


    public void SpawnCubes()
    {
        //calculer le nombre de cubes en fonction de la longueur du path
        int length = (int) pathCreator.path.length;
        int cubesToGenerateAlongPath = length / positionIncrement;

        float cubePos = firstCubePositionOffset + positionIncrement;

        for (int i = 0; i < cubesToGenerateAlongPath; i++)
        {
            if (i != 0)
            {
                

                Vector3 pos  = pathCreator.path.GetPointAtDistance(cubePos);
                Quaternion rot = pathCreator.path.GetRotationAtDistance(cubePos);

                Instantiate(cube, pos, rot);

                cubePos += positionIncrement;

            } else
            {
                Vector3 pos  = pathCreator.path.GetPointAtDistance(firstCubePositionOffset);
                Quaternion rot = pathCreator.path.GetRotationAtDistance(firstCubePositionOffset);

                Instantiate(cube, pos, rot);

            }
           
        }
    }

}

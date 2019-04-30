using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class PisteQuiOndule : MonoBehaviour
{
    public Vector3[] ancres;
    public bool closed;
    public float normalsAngle = 90;

    public PathCreator pathCreator;

    public float minXValue, minYValue, maxXValue, maxYValue, zIncrement;


    /******** METHODES ********/

    //Calculer une valeur pour X en fonction de différents paramètres
    float CalculateXValue(float min, float max)
    {
        float calculatedX = Random.Range(min, max);
        return calculatedX;
    }

    //Calculer une valeur pour Y en fonction de différents paramètres
    float CalculateYValue(float min, float max)
    {
        float calculatedY = Random.Range(min, max);
        return calculatedY;
    }

    //Calculer xyz en fonction des valeurs des méthodes précédentes, puis retourner
    Vector3[] GetTransforms(Vector3[] vectors)
    {
        for (int i = 3; i < vectors.Length; i++)
        {
            vectors[i].x = CalculateXValue(minXValue, maxXValue);
            vectors[i].y = CalculateYValue(minYValue, maxYValue);
            if (i >= 1)
            {
                vectors[i].z = vectors[i - 1].z + zIncrement;
            }
        }

        return vectors;
    }

    

    //Créer la piste
    BezierPath GeneratePath(Vector3[] points, bool IsClosed)
    {
        return new BezierPath(points, IsClosed, PathSpace.xyz);
    }

    //Execution avant la premiere frame
    private void Awake()
    {

        //Mise à jour de l'array
        ancres = GetTransforms(ancres);

        //Check si jamais bug dans le bordel
        if (ancres != null)
        {
            //Afficher la piste dans le world space
            pathCreator.bezierPath = GeneratePath(ancres, closed);
            pathCreator.bezierPath.GlobalNormalsAngle = normalsAngle;
            
            Debug.Log("Path Generated");

        }
    }



}

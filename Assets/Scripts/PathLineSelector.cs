using UnityEngine;

public class PathLineSelector : MonoBehaviour {

    public float minX,midX, maxX;
    

    private void Start() {
        SetLocalPositionX(minX, midX, maxX);
    }


    int RandomPathLine () 
    {
        return Random.Range(0, 3); //int Random.Range(max) est exclusif donc issues {0, 1, 2}
    }

    void SetLocalPositionX (float line1, float line2, float line3)
    {
        int line = RandomPathLine();
        if (line == 0)
        {
            transform.localPosition = new Vector3(line1, transform.localPosition.y, transform.localPosition.z);
        } else if (line == 1)
        {
            transform.localPosition = new Vector3(line2, transform.localPosition.y, transform.localPosition.z);
        } else if (line == 2)
        {
            transform.localPosition = new Vector3(line3, transform.localPosition.y, transform.localPosition.z);
        }
    }
}





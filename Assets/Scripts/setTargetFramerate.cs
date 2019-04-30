using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setTargetFramerate : MonoBehaviour
{
    public int targetFramerate;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = targetFramerate;
    }

}

using UnityEngine;
using System.Collections;
using PathCreation.Examples;

public class OndulationController : MonoBehaviour
{
    public float sideSpeed = 50f;
    public float XIncrement = 1;
    public float maxX, minX;
    public GameObject startButton;
    public GameObject selectLevelButton;
    public GameObject followScript;

    bool hasGameStarted = false;

    private void Start()
    {
        startButton.SetActive(true);
        selectLevelButton.SetActive(true);
        PathFollower script = followScript.GetComponent<PathFollower>();
        script.enabled = false;
    }

    public void ExecuteGame()
    {

        hasGameStarted = true;
        startButton.SetActive(false);
        PathFollower script = followScript.GetComponent<PathFollower>();
        script.enabled = true;
        //selectLevelButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (hasGameStarted)
        {
        //Input clavier
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.localPosition.x < maxX)
            {
            transform.localPosition = new Vector3(transform.localPosition.x + XIncrement, transform.localPosition.y, transform.localPosition.z);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.localPosition.x > minX)
            {
            transform.localPosition = new Vector3(transform.localPosition.x - XIncrement, transform.localPosition.y, transform.localPosition.z);
            }


            //Input mobile
            if (Input.touchCount == 1)
            {
                Touch touch = Input.GetTouch(0);
                Vector2 touchPosition = touch.position;
                if (touch.phase == TouchPhase.Began)
                {
                    if (touchPosition.x > (Screen.currentResolution.width / 2) && transform.localPosition.x < maxX)
                    {
                    transform.localPosition = new Vector3(transform.localPosition.x + XIncrement, transform.localPosition.y, transform.localPosition.z);
                    }
                    if (touchPosition.x < (Screen.currentResolution.width / 2) && transform.localPosition.x > minX)
                    {
                    transform.localPosition = new Vector3(transform.localPosition.x - XIncrement, transform.localPosition.y, transform.localPosition.z);
                    }
                }

            }
            
        }


    }
}



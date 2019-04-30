
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 20f;
    public float sideSpeed = 50f;
    public float XIncrement = 1;
    public float maxX, minX;

    public GameObject startButton;
    public GameObject selectLevelButton;

    bool hasGameStarted = false;

    private void Start()
    {
        startButton.SetActive(true);
        selectLevelButton.SetActive(true);
    }

    public void ExecuteGame()
    {

        hasGameStarted = true;
        startButton.SetActive(false);
        selectLevelButton.SetActive(false);
    }

   
    // Update is called once per frame
    void Update()
    {
        if (hasGameStarted)
        {
            //Mouvement constant
            transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
            
            
            //Input clavier
            if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maxX)
            {
                transform.position = new Vector3(transform.position.x + XIncrement, transform.position.y, transform.position.z);
                
            }  
            if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minX)
            {
                transform.position = new Vector3(transform.position.x - XIncrement, transform.position.y, transform.position.z);
                
            }


            //Input mobile
            if (Input.touchCount == 1)
            {
                Touch touch = Input.GetTouch(0);
                Vector2 touchPosition = touch.position;
                if (touch.phase == TouchPhase.Began)
                {
                    if (touchPosition.x > (Screen.currentResolution.width / 2) && transform.position.x < maxX)
                    {
                        transform.position = new Vector3(transform.position.x + XIncrement, transform.position.y, transform.position.z);
                    }
                    if (touchPosition.x < (Screen.currentResolution.width / 2) && transform.position.x > minX)
                    {
                        transform.position = new Vector3(transform.position.x - XIncrement, transform.position.y, transform.position.z);
                    }
                }

            }

        }
    }
}

using UnityEngine;

public class Show : MonoBehaviour
{
    public GameObject objectToShow;
    public GameObject buttonToHideOnClick;
    public GameObject buttonToShowAfterClick;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Return pressed");
            if (objectToShow.activeSelf == true)
            {
                objectToShow.SetActive(false);

            } else if (objectToShow.activeSelf == false)
            {
                objectToShow.SetActive(true);
                
            }
        } 
    }

    public void ShowLevelSelector ()
    {
        if (objectToShow.activeSelf == false)
        {
            buttonToHideOnClick.SetActive(false);
            objectToShow.SetActive(true);
            buttonToShowAfterClick.SetActive(true);
        } 
    }
    public void HideLevelSelector ()
    {
        if (objectToShow.activeSelf == true)
        {
            buttonToShowAfterClick.SetActive(false);
            objectToShow.SetActive(false);
            buttonToHideOnClick.SetActive(true);
        }
    }
}

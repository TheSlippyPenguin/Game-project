using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneFromButton : MonoBehaviour
{
    private string buttonText;
    int intText;
    private void Awake()
    {
        buttonText = GetComponent<Text>().text;
        intText = int.Parse(buttonText);
    }

    public void LoadScene ()
    {
        SceneManager.LoadScene(intText);
        Debug.Log("Scene loaded");
    }
}

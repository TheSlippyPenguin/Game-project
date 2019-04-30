using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public GameObject panel;
    public GameObject selector;
    public float delay;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            selector.SetActive(true);
            panel.SetActive(true);
            Destroy(other.gameObject);
            Invoke("LevelFinished", delay);

        }
    }

    public void LevelFinished()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

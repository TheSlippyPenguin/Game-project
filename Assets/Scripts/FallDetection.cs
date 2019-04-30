using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FallDetection : MonoBehaviour
{
    public float delay;
    public GameObject particle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);

            Instantiate(particle, other.transform.position, Quaternion.identity);

            Invoke("EndGame", delay);


        }
    }

    public void EndGame()
    {
        //Temporaire
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}

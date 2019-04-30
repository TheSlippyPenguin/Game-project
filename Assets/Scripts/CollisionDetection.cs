
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{
    public float delay;
    public GameObject particle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(particle, other.transform.position, Quaternion.identity);

            other.gameObject.SetActive(false);

            Invoke("EndGame", delay);

        }
    }

    public void EndGame ()
    {
        //Temporaire
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
}

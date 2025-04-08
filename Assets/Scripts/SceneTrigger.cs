using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
    public string sceneToLoad;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            float playerBottom = other.bounds.min.y;
            float triggerTop = GetComponent<Collider2D>().bounds.max.y;

            if (playerBottom > triggerTop)
            {
            Debug.Log("Scene trigger activated!");
            SceneManager.LoadScene(sceneToLoad);
            }
        }
    }
}
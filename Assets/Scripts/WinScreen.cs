using UnityEngine;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
{
    public GameObject winScreen;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            winScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}

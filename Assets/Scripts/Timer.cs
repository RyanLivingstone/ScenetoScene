using UnityEngine;
using UnityEngine.UI; // For UI elements

public class TimerManager : MonoBehaviour
{
    public float timeElapsed = 0f;  // Tracks the elapsed time
    public Text timerText;          // Reference to the UI Text element for the timer

    void Update()
    {
        // Count up the timeElapsed by the amount of time that passes each frame
        timeElapsed += Time.deltaTime;

        // Display the elapsed time in minutes and seconds format
        DisplayTime(timeElapsed);
    }

    // Display the elapsed time in minutes and seconds format
    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    private int score = 0;

    private void Start()
    {
        // Find the GameObject with ClicktoDestroy script
        ClicktoDestroy clickToDestroy = FindObjectOfType<ClicktoDestroy>();

        if (clickToDestroy != null)
        {
            // Subscribe to the ObjectDestroyed event
            clickToDestroy.ObjectDestroyed += IncrementScore;
        }
        else
        {
            Debug.LogWarning("No object with ClicktoDestroy script found in the scene.");
        }
    }

    private void IncrementScore()
    {
        score++;
        Debug.Log("Score: " + score);
    }
}

using UnityEngine;
using UnityEngine.UI;

public class Scoretext : MonoBehaviour
{
    public static Scoretext instance;
    public Text scoreText;
    public int score = 0;

    private void Awake()
    {
        // Ensure only one instance of Scoretext exists
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + " FILS";
    }

    // Method to add a point to the score
    public void AddPoint()
    {
        score++;
        scoreText.text = score.ToString() + " FILS";
    }
}

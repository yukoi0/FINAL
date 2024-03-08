using UnityEngine;
using UnityEngine.UI;

public class Scoretext : MonoBehaviour
{
    public static Scoretext instance;
    public Text scoreText;
    int score = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + "POINTS";
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + "POINTS";
    }
}

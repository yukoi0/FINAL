using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class helthUI : MonoBehaviour
{
    public Slider halthBarr;
    public Image fillImage;
    public static helthUI instance;
    [SerializeField] float minushealth = 5;

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

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (halthBarr.value == 0) 
        {
            SceneManager.LoadScene(4);
        }
    }
    public void updateHealth()
    {
        halthBarr.value -= minushealth;
    }
}

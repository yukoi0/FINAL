using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class ChangeGravityScale : MonoBehaviour
{
    private bool isGravityChanged = false; // Flag to track if gravity is already changed
    public RandomSpawner spawner;

    // Update is called once per frame
    void Update()
    {
        // Check if the button is clicked
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Check if gravity is not already changed
            if (!isGravityChanged)
            {
                ChangeGravity();
                isGravityChanged = true; // Set the flag to true to indicate that gravity has been changed
            }
        }
    }
    IEnumerator DisableSlowDown() 
    {
        yield return new WaitForSeconds(3);

        GameObject[] trashObjects = GameObject.FindGameObjectsWithTag("trash");

        foreach (GameObject trashObject in trashObjects)
        {
            Rigidbody2D rb2D = trashObject.GetComponent<Rigidbody2D>();
            if (rb2D != null)
            {
                Debug.Log("disabled");
                rb2D.gravityScale = 0.3f;
                
            }
        }
        spawner.AllowToSpawn = true;

    }

    // Method to change the gravity scale of objects tagged "trash"
    public void ChangeGravity()
    {
        GameObject[] trashObjects = GameObject.FindGameObjectsWithTag("trash");

        foreach (GameObject trashObject in trashObjects)
        {
            Rigidbody2D rb2D = trashObject.GetComponent<Rigidbody2D>();
            if (rb2D.gravityScale != 0.000000000001f)
            {
                rb2D.gravityScale = 0.000000000001f;
                StopAllCoroutines();
                StartCoroutine(DisableSlowDown());
                Debug.Log("slow");
                spawner.AllowToSpawn = false;
            }
        }
    }
}
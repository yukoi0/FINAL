using UnityEngine;

public class ClicktoDestroy : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);

        // Check if the object has been destroyed
        if (!gameObject)
        {
            Debug.Log("Object Destroyed!");

            // Call the AddPoint method of Scoretext instance to record the score
            if (Scoretext.instance != null)
            {
                Scoretext.instance.AddPoint();
            }
        }
    }
}

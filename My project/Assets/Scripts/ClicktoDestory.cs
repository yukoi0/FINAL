using UnityEngine;

public class ClicktoDestroy : MonoBehaviour
{
    public event System.Action ObjectDestroyed;

    private void OnDestroy()
    {
        ObjectDestroyed?.Invoke();
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        if (gameObject == null) // Check if the GameObject is destroyed
        {
            Debug.Log("hi");
        }
    }
   /* private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hi");
    }*/
}


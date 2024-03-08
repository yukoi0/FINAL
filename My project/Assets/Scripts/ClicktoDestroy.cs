using UnityEngine;

public class ClicktoDestroy : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
        Scoretext.instance.AddPoint();
    }
}

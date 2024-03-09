using UnityEngine;

public class ClicktoDestroy : MonoBehaviour
{
    public AudioSource src;
    public AudioClip clip;
    private void OnMouseDown()
    {
        Destroy(gameObject);
        Scoretext.instance.AddPoint();
        src.Play();
    }
}

/*using System.Collections;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour
{
    // Specify the layers for the prefabs
    public LayerMask prefabLayer;

    IEnumerator Start()
    {
        // Wait for a short delay to ensure all prefabs have spawned and settled
        yield return new WaitForSeconds(0.5f);

        // Ignore collisions between prefabs of the same layer
        Physics.IgnoreLayerCollision(prefabLayer, prefabLayer, true);
    }
}
    */
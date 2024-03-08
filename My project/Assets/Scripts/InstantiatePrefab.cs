using UnityEngine;

public class InstantiatePrefab : MonoBehaviour
{
    public GameObject prefab; // Assign your prefab in the Inspector

    void Start()
    {
        // Instantiate the prefab
        GameObject instantiatedPrefab = Instantiate(prefab, transform.position, Quaternion.identity);

        // Set the layer of the instantiated GameObject
        instantiatedPrefab.layer = LayerMask.NameToLayer("YourDesiredLayerName");
    }
}
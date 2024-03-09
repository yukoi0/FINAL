using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject[] ItemPrefab;
    public float Radius = 1;
    public bool AllowToSpawn;

    [SerializeField] GameObject[] Trash;
    [SerializeField] float secondspawn = 2f; // Initial spawn time
    [SerializeField] float minTras;
    [SerializeField] float maxTras;
    [SerializeField] float spawnTimeDecreaseRate = 0.02f; // Rate at which spawn time decreases
    [SerializeField] float minSpawnTime = 0.1f; // Minimum spawn time

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TrashSpawn());
    }

    IEnumerator TrashSpawn()
    {
        while (AllowToSpawn)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector2(wanted, transform.position.y);
            GameObject gameObject = Instantiate(ItemPrefab[Random.Range(0, ItemPrefab.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(secondspawn);

            // Decrease spawn time until it reaches the minimum spawn time
            if (secondspawn > minSpawnTime)
            {
                secondspawn -= spawnTimeDecreaseRate;
            }
            Destroy(gameObject, 5f);

        }
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(TrashSpawn());


    }
}

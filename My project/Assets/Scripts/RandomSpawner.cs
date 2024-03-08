using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{

    public GameObject[] ItemPrefab; // Change this line to declare ItemPrefab as an array
    public float Radius = 1;

    [SerializeField] GameObject[] Trash;
    [SerializeField] float secondspawn = 0.5f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TrashSpawn());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator TrashSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector2(wanted, transform.position.y);
            GameObject gameObject = Instantiate(ItemPrefab[Random.Range(0, ItemPrefab.Length)], position, Quaternion.identity); // Removed square brackets
            yield return new WaitForSeconds(secondspawn);
            Destroy(gameObject, 5f);
        }
    }
}

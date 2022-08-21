using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBehavior : MonoBehaviour
{
    [SerializeField] private GameObject foodPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(foodPrefab, new Vector2(Random.Range(-20, 20), Random.Range(-9, 9)), Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") {
            SpawnFood();
            Destroy(gameObject);
        }
    }

    private void SpawnFood() {
        Instantiate(foodPrefab,new Vector2(Random.Range(-20,20),Random.Range(-9,9)),Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CoinSpawner_1());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Coin()
    {
        float rnd = Random.Range(2.65f, -2.65f);
        Instantiate(coin, new Vector3(rnd, transform.position.y, transform.position.z), Quaternion.identity);
    }

    IEnumerator CoinSpawner_1()
    {
        while (true) {
            int time = Random.Range(10, 20);
            yield return new WaitForSeconds(time);
            Coin();
        }
    }
}

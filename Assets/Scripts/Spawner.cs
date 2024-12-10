using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject[] car;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Cars()
    {
        int rnd = Random.Range(0, car.Length);
        float rndXPos = Random.Range(-2.65f, 2.65f);
        Instantiate(car[rnd], new Vector3(rndXPos, transform.position.y, transform.position.z), Quaternion.Euler(0, 0, 90));
    }

    IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            Cars();
        }
    }
}

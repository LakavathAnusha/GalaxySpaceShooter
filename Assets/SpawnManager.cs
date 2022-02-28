using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject asreroidPrefab;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time >= 3f)
        {
            transform.position = new Vector3(8.5f, Random.Range(-4.5f, 4.5f), 0f);
            Instantiate(asreroidPrefab, transform.position, Quaternion.identity);
            time = 0.0f;
        }

    }
}

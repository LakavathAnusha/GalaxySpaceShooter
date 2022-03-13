using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlanet : MonoBehaviour
{
    public GameObject planetPrefab;
    float time;
    public float speed;
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
            transform.position = new Vector3(6f,0f, 0f);
            Instantiate(planetPrefab, transform.position, Quaternion.identity);
            time = 0.0f;
        }
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.x < -6f)
        {
            Destroy(gameObject, 3.0f);
        }
    }
}

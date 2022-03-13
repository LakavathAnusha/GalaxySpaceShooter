using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        transform.Rotate(10.0f, 0f, 0f, Space.Self);
        if(transform.position.x<-9.0f)
        {
            Destroy(gameObject,3.0f);
        }

    }
    /*private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }*/
}

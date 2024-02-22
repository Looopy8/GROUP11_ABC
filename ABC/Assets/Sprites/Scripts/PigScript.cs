using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigScript : MonoBehaviour
{
    float height = 3f;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newX = Mathf.Sin(Time.time * 1) * height + pos.x;
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Turn")
        {
            transform.Rotate(Vector3.up * 180);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ori : MonoBehaviour
{
    public int speed = 3;
    public Rigidbody2D rigidbody;
   
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        
    }

   
    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        Debug.Log("move");
        rigidbody.velocity = new Vector3(move*speed, rigidbody.velocity.y, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = new Vector3(rigidbody.velocity.y, speed);
        }
    }
}

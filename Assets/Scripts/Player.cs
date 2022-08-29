using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        if (Input.GetAxis("Horizontal") > 0)  //it is positive---right and left
        {
            rigidbody2d.velocity = new Vector2(speed, 0f);
        }
        else if (Input.GetAxis("Horizontal") < 0)   //it is negative 
        {
            rigidbody2d.velocity = new Vector2(-speed, 0f);
        }
        else if (Input.GetAxis("Vertical") > 0)  //it is positive---right and left
        {
            rigidbody2d.velocity = new Vector2( 0f,speed);
        }
        else if (Input.GetAxis("Vertical") < 0)   //it is negative 
        {
            rigidbody2d.velocity = new Vector2(0f, -speed);
        }
        else if (Input.GetAxis("Vertical")==0 && Input.GetAxis("Horizontal") == 0)  // stop
        {
            rigidbody2d.velocity = new Vector2(0f, 0f);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Door")
        {
            Debug.Log("level complete");
        }
    }

}
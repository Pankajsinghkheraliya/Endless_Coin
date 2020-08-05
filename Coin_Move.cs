using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Move : MonoBehaviour
{
    public Transform Transform;
    public Rigidbody rb;
    public float forwordForce = 100f;
    public float sideforce = 100f;
    public float jumpspeed = 100f;
  
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown("q"))
        {
            forwordForce = forwordForce + 10;
        }

        if (Input.GetKeyDown("e"))
        {
            forwordForce = forwordForce - 10;
        }

       // if (Input.GetKey("w"))
        //{
            rb.AddForce(0, 0, forwordForce * Time.deltaTime, ForceMode.Acceleration);
            
       // }


        if (Input.GetKey("d"))
        {
            rb.AddForce(sideforce * Time.deltaTime, 0, 0);

        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideforce * Time.deltaTime, 0, 0);
        }

       /* if (Input.GetKeyUp("space"))
        {
            rb.AddForce(Vector3.up * jumpspeed, ForceMode.Impulse );
            
        }
       if (Input.GetKeyUp("s"))
        {
            rb.AddForce(Vector3.down * jumpspeed, ForceMode.Impulse);

        }*/

        if (Input.GetKey("r"))
        {
            
        }
    }


}

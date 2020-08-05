using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Side_Forse : MonoBehaviour
{
    public int sideforce1 = 100;
    public Transform Transform;
    public Rigidbody rb;

    public void Update()
    {

    }
    
    public void Left_Button()
    {
        rb.AddForce(-sideforce1 * Time.deltaTime, 0, 0, ForceMode.Impulse);
    }
    public void Right_Button()
    {
        rb.AddForce(sideforce1 * Time.deltaTime, 0, 0, ForceMode.Impulse);
    }
}

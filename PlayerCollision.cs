using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public Coin_Move movement;
    public Button_Side_Forse BtnMovement;


    void OnCollisionEnter (Collision collisionInfor)
    {
        if (collisionInfor.collider.tag == "Barriers")
        {
            movement.enabled = false;
            BtnMovement.enabled = false;
           
        }
    }

}

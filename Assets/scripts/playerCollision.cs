 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{   
    public playerControl playerMovement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "obstacles"){
            playerMovement.enabled = false;
            Debug.Log("hit");
        }
        Debug.Log(collisionInfo.collider);
    }
}

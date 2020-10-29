using JetBrains.Annotations;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo) //call if a collision happens
    {

        //Debug.Log("We hit something!");
        //Debug.Log(collisionInfo.collider.name); //the name of the stuff we hit

        //if(collisionInfo.collider.name == "Obstacle")
        if(collisionInfo.collider.tag == "Obstacle"){

            //Debug.Log("We hit an obstacle!");

            movement.enabled = false; //stop the movement
            //GetComponent<PlayerMovement>().enabled = false; //replace movement with GetComponent<PlayerMovement>()

            FindObjectOfType<GameManager>().EndGame(); //find object of type "GameManager", and call Endgame(), Endgame() should be public
        }
        
    }

}

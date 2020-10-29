using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;

    void OnTriggerEnter(Collider other) //if the collider is a trigger, use this instead of OnCollisionEnter()
                                        //trigger is defined by selecting "Is Trigger" in Box Collider
    {
        gameManager.CompleteLevel();
    }

}

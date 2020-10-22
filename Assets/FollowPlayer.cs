using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //we have a "Transform" component outside (x y z axis position)
    public Transform player;
    public Vector3 offset; //Vector3 is a variable of 3 axis

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position);

        //make position of the current project same as player's position
        //...and get back a bit with offset
        transform.position = player.position + offset;
    }
}

using UnityEngine;
using UnityEngine.UI; //to modify UI

public class Score : MonoBehaviour
{
    public Transform player; //Transform is responsible for position
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0"); //int to String before assignment, shown in whole numbers
    }
}

using UnityEngine;
using UnityEngine.SceneManagement; //use it when want to reset and change into another scene

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false; //do not add public it you don't need to relate to something

    public float restartDelay = 1f; 
        
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");


            //Restart(); //Restart game
            Invoke("Restart", restartDelay);
        }
    }

    void Restart ()
    {
        //SceneManager.LoadScene("level01");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //(re)load the current theme
    }
}

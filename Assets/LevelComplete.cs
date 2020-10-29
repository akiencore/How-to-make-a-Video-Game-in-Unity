using UnityEngine;
using UnityEngine.SceneManagement; //use it when want to reset and change into another scene

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}

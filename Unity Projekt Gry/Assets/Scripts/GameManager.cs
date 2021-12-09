using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;

    public GameObject CompleteLevelUI;
    public void GameOver()
    {
        if(GameHasEnded == false)
        {
            GameHasEnded = true;
            Restart();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }
}

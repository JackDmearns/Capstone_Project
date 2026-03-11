using UnityEngine;

public class Start_Death_Conversation : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject Start;

  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }

            else
            {
                Paused();
            }
        }
    }

    void Resume()
    {
        Start.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Paused()
    {
        Start.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}

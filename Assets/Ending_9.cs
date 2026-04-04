using UnityEngine;

public class Ending_9 : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject Ending9;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
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

    public void Resume()
    {
        Ending9.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Paused()
    {
        Ending9.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}

using UnityEngine;

public class Ending_5 : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject Ending5;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
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
        Ending5.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Paused()
    {
        Ending5.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}

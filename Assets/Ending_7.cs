using UnityEngine;

public class Ending_7 : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject Ending7;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
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
        Ending7.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Paused()
    {
        Ending7.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}

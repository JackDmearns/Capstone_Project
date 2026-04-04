using UnityEngine;

public class Ending_2 : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject Ending2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
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
        Ending2.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Paused()
    {
        Ending2.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}

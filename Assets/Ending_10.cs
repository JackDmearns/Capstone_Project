using UnityEngine;

public class Ending_10 : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject Ending10;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
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
        Ending10.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Paused()
    {
        Ending10.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}

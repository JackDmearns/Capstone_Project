using UnityEngine;

public class Ending_6 : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject Ending6;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
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
        Ending6.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Paused()
    {
        Ending6.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}

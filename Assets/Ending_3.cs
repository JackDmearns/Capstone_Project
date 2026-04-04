using UnityEngine;

public class Ending_3 : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject Ending3;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)) 
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
        Ending3.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Paused()
    {
        Ending3.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}

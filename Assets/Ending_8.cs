using UnityEngine;

public class Ending_8 : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject Ending8;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
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
        Ending8.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Paused()
    {
        Ending8.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}

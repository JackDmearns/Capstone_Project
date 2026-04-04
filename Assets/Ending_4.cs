using UnityEngine;

public class Ending_4 : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject Ending4;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
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
        Ending4.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Paused()
    {
        Ending4.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RestartLevelTimer : MonoBehaviour
{
    public float restartDelay = 10;

    void Start()
    {
        Invoke("Restart", restartDelay);
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

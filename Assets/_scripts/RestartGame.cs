using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class RestartGame : MonoBehaviour
{

    public void SwitchScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class Vencer : MonoBehaviour
{
    private PlayerController p;
    private void OnTriggerEnter(Collider other)
    {
        p = other.gameObject.GetComponent<PlayerController>();
        if(other.gameObject.CompareTag("Player"))
        {
                SceneManager.LoadScene("WinScene");
        }
    }
}

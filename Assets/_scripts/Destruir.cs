using UnityEngine;
using UnityEngine.SceneManagement;

public class Destruir : MonoBehaviour
{
    private PlayerController p;
    private void OnTriggerEnter(Collider other)
    {
        p = other.gameObject.GetComponent<PlayerController>();
        if(other.gameObject.CompareTag("Player"))
        {
                p.vivo = false;
                p.gameObject.SetActive(false);
                SceneManager.LoadScene("GameOverScene");
        }
    }
}

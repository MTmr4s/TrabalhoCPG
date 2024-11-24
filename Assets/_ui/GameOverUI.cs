using UnityEngine;
using UnityEngine.UIElements;

public class GameOverUI : MonoBehaviour
{
    public PlayerController player;
    
    private void OnEnable()
    {
        
        
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Button btRestart = root.Q<Button>("btRestart");

        btRestart.clicked += () => 
        {
            Debug.Log("Botão btRestart clicado!");
            player.Restaurar();
            HideUi(false);
            //gameObject.SetActive(false);
        };
    }

    public void HideUi(bool value){
        gameObject.GetComponent<UIDocument>().enabled = value;
    }
}

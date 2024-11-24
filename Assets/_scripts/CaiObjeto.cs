using UnityEngine;

public class CaiObjeto : MonoBehaviour
{
    public GameObject objeto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            objeto.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}

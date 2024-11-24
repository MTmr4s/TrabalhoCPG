using UnityEngine;

public class CameraController : MonoBehaviour
{
     public Transform focoPlayer;
    public Transform camPlayer;

    void Start()
    {
        transform.position = camPlayer.position;
        transform.rotation = camPlayer.rotation;
        transform.LookAt(focoPlayer);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = camPlayer.position;
        transform.rotation = camPlayer.rotation;
        transform.LookAt(focoPlayer);
    }
}

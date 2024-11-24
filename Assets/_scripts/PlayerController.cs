using UnityEngine;

public class PlayerController : MonoBehaviour
{
     public float velocidade = 5f; //velocidade de movimentacao do jogador
    public float velRot = 300f; //velocidade de rotacao do jogador
    public float forcaSalto = 0.5f; //força de impulso do salto
    public float alturaSalto = 0f; //altura atual do jogador
    public float alturaMax = 1f; //altura maxima do salto
    public float ccgravidade = 0.5f; //força de gravidade
    public bool vivo = true;
    public GameOverUI goui;
    private Vector3 moveDirection = Vector3.zero; //vetor para determinar posicao
    private Vector3 posInicial;
    private CharacterController cc; //controle do jogador
    private bool pulando = false; //verifica se o jogador esta pulando
    
    void Start()
    {
        posInicial = transform.localPosition;
        //posInicial = new Vector3(0.1f,3.61f,-5.8f);
        cc = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float horizRaw = Input.GetAxisRaw("Horizontal") * Time.deltaTime * velocidade;
        float vertRaw = Input.GetAxisRaw("Vertical") * Time.deltaTime * velocidade;
        if (cc.isGrounded)
        {   
            moveDirection = new Vector3(vertRaw, 0, -horizRaw);
            moveDirection = transform.TransformDirection(moveDirection);         
        }
        if (pulando == true && transform.localPosition.y < alturaSalto)
        {
            moveDirection.y += forcaSalto * Time.deltaTime;
        }
        else
        {
            moveDirection.y -= ccgravidade * Time.deltaTime;
            pulando = false;
        }
        cc.Move(moveDirection);
        transform.Rotate(0, Input.GetAxis("Mouse X") * Time.deltaTime * velRot, 0);
        //transform.Translate( Input.GetAxis("Vertical") * Time.deltaTime * velocidade, 0, 0);
        //transform.Translate( vert, 0, -horiz);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            alturaSalto = transform.localPosition.y + alturaMax;
            pulando = true;
        }
        if(Input.GetKeyDown(KeyCode.R)) Restaurar();
        
    }

    
    public void Restaurar()
    {
            transform.localPosition = posInicial;   
            Debug.Log(transform.localPosition);
            if(!gameObject.activeSelf)
            {
                gameObject.SetActive(true);
                vivo = true;
                
            }
    }
}

using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed = 10.0f; // Velocidad de movimiento del paddle
    public bool isPlayerOne; // Determina si este paddle es para el Jugador 1
    public bool isPlayerTwo; // Determina si este paddle es para el Jugador 2

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isPlayerOne)
        {
            float moveVertical = Input.GetAxis("Vertical1"); // Configurar Input Manager para "Vertical1"
            rb.velocity = new Vector2(0, moveVertical * speed);
        }
        else if (isPlayerTwo)
        {
            float moveVertical = Input.GetAxis("Vertical2"); // Configurar Input Manager para "Vertical2"
            rb.velocity = new Vector2(0, moveVertical * speed);
        }
    }
}

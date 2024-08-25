using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 10.0f; // Velocidad inicial de la bola
    private bool ballLaunched = false;
    private Rigidbody2D rb;
    private Vector2 startPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position; // Guarda la posición inicial de la bola
        ResetBall(); // Resetea la bola al inicio
    }

    void Update()
    {
        // Comprueba si la tecla de espacio es presionada y la bola aún no ha sido lanzada
        if (Input.GetKeyDown(KeyCode.Space) && !ballLaunched)
        {
            LaunchBall();
            ballLaunched = true; // Establece el estado de la bola como lanzada
        }
    }

    private void LaunchBall()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    public void ResetBall()
    {
        ballLaunched = false;
        rb.velocity = Vector2.zero; // Detiene la bola
        transform.position = startPosition; // Resetea la posición a la inicial
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Aquí puedes añadir lógica adicional para cuando la bola golpea algo
    }
}

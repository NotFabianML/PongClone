using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounceScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer rbSprite;
    private float speed = 5;
    private float maxSpeed = 12;
    public LogicScript logic;
    
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

        //StartCoroutine(WaitAndLaunchBall());

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            LaunchBall();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int randomNumber = Random.Range(0, 2);
        if (randomNumber == 0)
        {
            increseBallSpeed();
        }
    }

    private void LaunchBall()
    {

        // Aplica una fuerza inicial en una dirección aleatoria
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    public void ResetBall()
    {
        // Restablece la posición de la pelota al centro o a una posición inicial
        transform.position = Vector3.zero;

        // Detiene la pelota
        speed = 5;
        rb.velocity = Vector2.zero;

        // Opcional: Esperar un breve momento antes de lanzar la pelota nuevamente
        rbSprite.color = Color.white;
        StartCoroutine(WaitAndLaunchBall());
    }

    private IEnumerator WaitAndLaunchBall()
    {
        yield return new WaitForSeconds(15); // Espera 2 segundos
        LaunchBall(); // Lanza la pelota nuevamente
    }

    private void increseBallSpeed()
    {
        if (speed <= maxSpeed)
        {
            speed += 1;
            rb.velocity = rb.velocity.normalized * speed;
        } else
        {
            rbSprite.color = Color.red;
        }
    }
}

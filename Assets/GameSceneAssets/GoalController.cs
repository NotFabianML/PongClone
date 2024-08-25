using UnityEngine;

public class GoalController : MonoBehaviour
{
    public GameController gameController; // Referencia al controlador del juego

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ball")) // Asegúrate de que el objeto que entra en la portería es la bola
        {
            // Aquí podrías determinar cuál portería fue golpeada para saber a qué jugador asignar el punto.
            // Por ejemplo, podrías usar el nombre del GameObject o una variable específica.

            if (this.gameObject.name == "LeftGoal") // Suponiendo que este es el nombre de la portería izquierda
            {
                gameController.PlayerTwoScored(); // Suponiendo que anotar en la portería izquierda da puntos al jugador 2
            }
            else if (this.gameObject.name == "RightGoal") // Suponiendo que este es el nombre de la portería derecha
            {
                gameController.PlayerOneScored(); // Suponiendo que anotar en la portería derecha da puntos al jugador 1
            }

            // Llama a ResetBall en el BallController
            other.gameObject.GetComponent<BallController>().ResetBall();
        }
    }
}

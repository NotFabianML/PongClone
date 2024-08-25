using UnityEngine;

public class GoalController : MonoBehaviour
{
    public GameController gameController; // Referencia al controlador del juego

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ball")) // Aseg�rate de que el objeto que entra en la porter�a es la bola
        {
            // Aqu� podr�as determinar cu�l porter�a fue golpeada para saber a qu� jugador asignar el punto.
            // Por ejemplo, podr�as usar el nombre del GameObject o una variable espec�fica.

            if (this.gameObject.name == "LeftGoal") // Suponiendo que este es el nombre de la porter�a izquierda
            {
                gameController.PlayerTwoScored(); // Suponiendo que anotar en la porter�a izquierda da puntos al jugador 2
            }
            else if (this.gameObject.name == "RightGoal") // Suponiendo que este es el nombre de la porter�a derecha
            {
                gameController.PlayerOneScored(); // Suponiendo que anotar en la porter�a derecha da puntos al jugador 1
            }

            // Llama a ResetBall en el BallController
            other.gameObject.GetComponent<BallController>().ResetBall();
        }
    }
}

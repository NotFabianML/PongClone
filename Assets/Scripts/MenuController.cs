using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Referencias a los paneles del menú
    public GameObject mainMenuPanel;
    public GameObject lanMenuPanel;

    void Start()
    {
        // Asegúrate de que solo el menú principal sea visible al inicio
        mainMenuPanel.SetActive(true);
        lanMenuPanel.SetActive(false);
    }

    // Llamado cuando se hace clic en el botón "Jugar 2 Jugadores"
    public void PlayTwoPlayerGame()
    {
        // Aquí puedes cargar la escena del juego o lo que necesites para iniciar el juego para 2 jugadores
        Debug.Log("Cargo escena");
        SceneManager.LoadScene("GameScene"); // Asegúrate de que "GameScene" sea el nombre de tu escena de juego
    }

    // Llamado cuando se hace clic en el botón "Jugar LAN"
    public void OpenLANMenu()
    {
        // Muestra el menú LAN y oculta el menú principal
        mainMenuPanel.SetActive(false);
        lanMenuPanel.SetActive(true);
    }

    // Llamado cuando se elige "Ser Host" o "Ser Cliente" en el menú LAN
    public void StartLANGame(bool isHost)
    {
        // Aquí puedes iniciar la lógica para crear o unirse a una partida LAN
        // Usa 'isHost' para determinar si el jugador será el host o el cliente

        // Por ejemplo:
        // if (isHost)
        // {
        //     // Lógica para ser el host
        // }
        // else
        // {
        //     // Lógica para unirse como cliente
        // }

        SceneManager.LoadScene("LANGameScene"); // Asegúrate de que "LANGameScene" sea el nombre de tu escena de juego LAN
    }

    // Llamado por un botón en el menú LAN para volver al menú principal
    public void BackToMainMenu()
    {
        lanMenuPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
}

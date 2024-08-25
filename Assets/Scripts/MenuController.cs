using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Referencias a los paneles del men�
    public GameObject mainMenuPanel;
    public GameObject lanMenuPanel;

    void Start()
    {
        // Aseg�rate de que solo el men� principal sea visible al inicio
        mainMenuPanel.SetActive(true);
        lanMenuPanel.SetActive(false);
    }

    // Llamado cuando se hace clic en el bot�n "Jugar 2 Jugadores"
    public void PlayTwoPlayerGame()
    {
        // Aqu� puedes cargar la escena del juego o lo que necesites para iniciar el juego para 2 jugadores
        Debug.Log("Cargo escena");
        SceneManager.LoadScene("GameScene"); // Aseg�rate de que "GameScene" sea el nombre de tu escena de juego
    }

    // Llamado cuando se hace clic en el bot�n "Jugar LAN"
    public void OpenLANMenu()
    {
        // Muestra el men� LAN y oculta el men� principal
        mainMenuPanel.SetActive(false);
        lanMenuPanel.SetActive(true);
    }

    // Llamado cuando se elige "Ser Host" o "Ser Cliente" en el men� LAN
    public void StartLANGame(bool isHost)
    {
        // Aqu� puedes iniciar la l�gica para crear o unirse a una partida LAN
        // Usa 'isHost' para determinar si el jugador ser� el host o el cliente

        // Por ejemplo:
        // if (isHost)
        // {
        //     // L�gica para ser el host
        // }
        // else
        // {
        //     // L�gica para unirse como cliente
        // }

        SceneManager.LoadScene("LANGameScene"); // Aseg�rate de que "LANGameScene" sea el nombre de tu escena de juego LAN
    }

    // Llamado por un bot�n en el men� LAN para volver al men� principal
    public void BackToMainMenu()
    {
        lanMenuPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
}

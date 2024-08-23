using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Button playButton;
    public Button tryButton; 
    public Button returnButton;
    public Button returnButton2;
    void Start()
    {
        returnButton.onClick.AddListener(RevenirAuMenu);
        returnButton2.onClick.AddListener(RevenirAuMenu);
        playButton.onClick.AddListener(Rejouer);
        tryButton.onClick.AddListener(Rejouer);
    }

    void RevenirAuMenu()
    {
        // Charger la sc�ne du menu principal   
        SceneManager.LoadScene("Menu"); // Remplacez "Menu" par le nom de votre sc�ne de menu
    }

    void Rejouer()
    {
        // Recharger la sc�ne actuelle pour rejouer
        SceneManager.LoadScene("Game");
    }
}

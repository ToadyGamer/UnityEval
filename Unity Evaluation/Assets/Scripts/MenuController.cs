using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Button jouerButton;
    public Button creditsButton;
    public Button quitterButton;

    void Start()
    {
        // Assigner les fonctions aux boutons
        jouerButton.onClick.AddListener(ChargerJeu);
        creditsButton.onClick.AddListener(ChargerCredits);
        quitterButton.onClick.AddListener(QuitterApplication);
    }

    void ChargerJeu()
    {
        // Remplacez "Jeu" par le nom de la scène que vous souhaitez charger
        SceneManager.LoadScene("Game");
    }

    void ChargerCredits()
    {
        // Remplacez "Credits" par le nom de la scène des crédits
        SceneManager.LoadScene("Credits");
    }

    void QuitterApplication()
    {
        // Quitte l'application
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditsController : MonoBehaviour
{
    public Button retourButton;

    void Start()
    {
        // Assigner la fonction au bouton
        retourButton.onClick.AddListener(RevenirAuMenu);
    }

    void RevenirAuMenu()
    {
        // Charge la scène du menu principal
        SceneManager.LoadScene("Menu"); // Remplacez "Menu" par le nom de votre scène de menu
    }
}

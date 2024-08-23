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
        // Charge la sc�ne du menu principal
        SceneManager.LoadScene("Menu"); // Remplacez "Menu" par le nom de votre sc�ne de menu
    }
}

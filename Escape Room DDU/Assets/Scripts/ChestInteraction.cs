using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChestInteraction : MonoBehaviour
{
    public GameObject chestUI; // Canvas for at indtaste koden
    public TMP_InputField inputField1, inputField2, inputField3; // Inputfelter
    public Sprite openChestSprite; // Sprite for åben kiste

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Hent SpriteRenderer på kisten
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Skjul UI ved start
        chestUI.SetActive(false);
    }

    void OnMouseDown()
    {
        // Vis UI, når kisten klikkes
        chestUI.SetActive(true);
    }

    public void CheckCode()
    {
        // Hvis den rigtige kode indtastes, åbnes kisten
        if (inputField1.text == "1" && inputField2.text == "2" && inputField3.text == "3")
        {
            spriteRenderer.sprite = openChestSprite; // Skift til åben kiste
            chestUI.SetActive(false); // Skjul UI
        }
        else
        {
            Debug.Log("Forkert kode!");
        }
    }
}

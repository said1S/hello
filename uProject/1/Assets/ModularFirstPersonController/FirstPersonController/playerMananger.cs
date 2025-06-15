using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor;

public class playerMananger : MonoBehaviour
{
    public static int health;
    public static bool gameOver;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI CoinsText;
    public static int coins;
    public GameObject menu;
    public GameObject dethMenu;
    public static bool is_menu_turnOn;

    private void Start()
    {
        gameOver = false;
        health = 100;
        is_menu_turnOn = false;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        healthText.text = "" + health;
        CoinsText.text = "" + coins;

        if (gameOver)
        {
            Debug.Log("ןמלונ");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            dethMenu.SetActive(true);
            Time.timeScale = 0;
        }

        EnableMenu();
    }

    public void reZero()
    {
        Debug.Log("ÂÎÇÐÀÄÈËÑ‗");
        gameOver = false;
        dethMenu.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        health = 100;
    }

    public void exit()
    {
        SceneManager.LoadScene(0);
        Debug.Log("ןמלונ");
        gameOver = false;
        dethMenu.SetActive(false);
        Time.timeScale = 1;
        health = 100;
    }

    public void cont()
    {
        FirstPersonController.kostilDlaMenu = true;
        Debug.Log("אכ¸ םאץףיייייייייי");
    }

    private void EnableMenu()
    {
        if (is_menu_turnOn)
            menu.SetActive(true);

        else menu.SetActive(false);
    }

    public static void Damage (int damageCount)
    {
        health -= damageCount;

        if (health <= 0)
            gameOver = true;
    }

    public void sceneChange (int numScene)
    {
        SceneManager.LoadScene(numScene);
    }

}

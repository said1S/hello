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
    public static bool is_menu_turnOn;

    private void Start()
    {
        gameOver = false;
        health = 100;
        is_menu_turnOn = false;
    }

    private void Update()
    {
        healthText.text = "" + health;
        CoinsText.text = "" + coins;

        if (gameOver)
        {
            Debug.Log("онлеп");
            SceneManager.LoadScene(1);
        }

        EnableMenu();
    }

    public void cont()
    {
        FirstPersonController.kostilDlaMenu = true;
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

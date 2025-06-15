using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuMenengere : MonoBehaviour
{
    private void Awake()
    {

    }
    public void sceneChange(int numScene)
    {
        SceneManager.LoadScene(numScene);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuMenengere : MonoBehaviour
{
    public void sceneChange(int numScene)
    {
        SceneManager.LoadScene(numScene);
    }
}

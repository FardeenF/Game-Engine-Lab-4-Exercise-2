using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GoToFirstScene()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void GotToSecondScene()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void GotToThirdScene()
    {
        SceneManager.LoadScene("Level 3");
    }
}

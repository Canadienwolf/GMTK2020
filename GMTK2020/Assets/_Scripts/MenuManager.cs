using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void Activate(GameObject obj)
    {
        obj.SetActive(true);
    }

    public void Deactivate(GameObject obj)
    {
        obj.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

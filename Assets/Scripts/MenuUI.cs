using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUI : MonoBehaviour
{
    public static MenuUI menuUi;
    public TMP_InputField inputField;
    public string player_name;

    public void Awake()
    {
        if (menuUi == null)
        {
            menuUi = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void SetPlayerName()
    {
        player_name = inputField.text;
        SceneManager.LoadScene(1);
    }
 
    public void Exit()
    {
 
        EditorApplication.ExitPlaymode();
        Application.Quit();

    }
}

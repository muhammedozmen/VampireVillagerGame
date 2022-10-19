using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowRoleButton : MonoBehaviour
{
    public void showRole1()
    {
        SceneManager.LoadScene("Player1");
    }

    public void showRole2()
    {
        SceneManager.LoadScene("Player2");
    }

    public void showRole3()
    {
        SceneManager.LoadScene("Player3");
    }

    public void showRole4()
    {
        SceneManager.LoadScene("Player4");
    }

    public void showRole5()
    {
        SceneManager.LoadScene("Player5");
    }
}

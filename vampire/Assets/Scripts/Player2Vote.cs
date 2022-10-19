using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2Vote : MonoBehaviour
{
    public static bool player2Vote = false;

    private void Start()
    {
        if (Game.player1dead)
        {
            GameObject.Find("Button").SetActive(false);
        }
        if (Game.player3dead)
        {
            GameObject.Find("Button2").SetActive(false);
        }
        if (Game.player4dead)
        {
            GameObject.Find("Button3").SetActive(false);
        }
        if (Game.player5dead)
        {
            GameObject.Find("Button4").SetActive(false);
        }
    }

    public void voteP1()
    {
        Game.player1IsVoted++;
        player2Vote = true;
        if (Game.player3dead == false && Player3Vote.player3Vote == false)
        {
            SceneManager.LoadScene("Player3Vote");
        }
        else if (Game.player4dead == false && Player4Vote.player4Vote == false)
        {
            SceneManager.LoadScene("Player4Vote");
        }
        else if (Game.player5dead == false && Player5Vote.player5Vote == false)
        {
            SceneManager.LoadScene("Player5Vote");
        }
        else if (Game.player1dead == false && Player1Vote.player1Vote == false)
        {
            SceneManager.LoadScene("Player1Vote");
        }
        else
        {
            SceneManager.LoadScene("VotingEnd");
        }
    }

    public void voteP3()
    {
        Game.player3IsVoted++;
        player2Vote = true;
        if (Game.player3dead == false && Player3Vote.player3Vote == false)
        {
            SceneManager.LoadScene("Player3Vote");
        }
        else if (Game.player4dead == false && Player4Vote.player4Vote == false)
        {
            SceneManager.LoadScene("Player4Vote");
        }
        else if (Game.player5dead == false && Player5Vote.player5Vote == false)
        {
            SceneManager.LoadScene("Player5Vote");
        }
        else if (Game.player1dead == false && Player1Vote.player1Vote == false)
        {
            SceneManager.LoadScene("Player1Vote");
        }
        else
        {
            SceneManager.LoadScene("VotingEnd");
        }
    }

    public void voteP4()
    {
        Game.player4IsVoted++;
        player2Vote = true;
        if (Game.player3dead == false && Player3Vote.player3Vote == false)
        {
            SceneManager.LoadScene("Player3Vote");
        }
        else if (Game.player4dead == false && Player4Vote.player4Vote == false)
        {
            SceneManager.LoadScene("Player4Vote");
        }
        else if (Game.player5dead == false && Player5Vote.player5Vote == false)
        {
            SceneManager.LoadScene("Player5Vote");
        }
        else if (Game.player1dead == false && Player1Vote.player1Vote == false)
        {
            SceneManager.LoadScene("Player1Vote");
        }
        else
        {
            SceneManager.LoadScene("VotingEnd");
        }
    }

    public void voteP5()
    {
        Game.player5IsVoted++;
        player2Vote = true;
        if (Game.player3dead == false && Player3Vote.player3Vote == false)
        {
            SceneManager.LoadScene("Player3Vote");
        }
        else if (Game.player4dead == false && Player4Vote.player4Vote == false)
        {
            SceneManager.LoadScene("Player4Vote");
        }
        else if (Game.player5dead == false && Player5Vote.player5Vote == false)
        {
            SceneManager.LoadScene("Player5Vote");
        }
        else if (Game.player1dead == false && Player1Vote.player1Vote == false)
        {
            SceneManager.LoadScene("Player1Vote");
        }
        else
        {
            SceneManager.LoadScene("VotingEnd");
        }
    }
}

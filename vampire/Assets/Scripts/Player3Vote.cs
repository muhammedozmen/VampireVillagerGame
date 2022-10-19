using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player3Vote : MonoBehaviour
{
    public static bool player3Vote = false;

    private void Start()
    {
        if (Game.player1dead)
        {
            GameObject.Find("Button").SetActive(false);
        }
        if (Game.player2dead)
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
        player3Vote = true;
        if (Game.player4dead == false && Player4Vote.player4Vote == false)
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
        else if (Game.player2dead == false && Player2Vote.player2Vote == false)
        {
            SceneManager.LoadScene("Player2Vote");
        }
        else
        {
            SceneManager.LoadScene("VotingEnd");
        }
    }

    public void voteP2()
    {
        Game.player2IsVoted++;
        player3Vote = true;
        if (Game.player4dead == false && Player4Vote.player4Vote == false)
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
        else if (Game.player2dead == false && Player2Vote.player2Vote == false)
        {
            SceneManager.LoadScene("Player2Vote");
        }
        else
        {
            SceneManager.LoadScene("VotingEnd");
        }
    }

    public void voteP4()
    {
        Game.player4IsVoted++;
        player3Vote = true;
        if (Game.player4dead == false && Player4Vote.player4Vote == false)
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
        else if (Game.player2dead == false && Player2Vote.player2Vote == false)
        {
            SceneManager.LoadScene("Player2Vote");
        }
        else
        {
            SceneManager.LoadScene("VotingEnd");
        }
    }

    public void voteP5()
    {
        Game.player5IsVoted++;
        player3Vote = true;
        if (Game.player4dead == false && Player4Vote.player4Vote == false)
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
        else if (Game.player2dead == false && Player2Vote.player2Vote == false)
        {
            SceneManager.LoadScene("Player2Vote");
        }
        else
        {
            SceneManager.LoadScene("VotingEnd");
        }
    }
}

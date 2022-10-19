using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1Vote : MonoBehaviour
{
    public static bool player1Vote = false;
    
    private void Start()
    {
        if(Game.player2dead == true)
        {
            GameObject.Find("Button").SetActive(false);
        }
        if (Game.player3dead == true)
        {
            GameObject.Find("Button2").SetActive(false);
        }
        if (Game.player4dead == true)
        {
            GameObject.Find("Button3").SetActive(false);
        }
        if (Game.player5dead == true)
        {
            GameObject.Find("Button4").SetActive(false);
        }
    }

    public void voteP2()
    {
        Game.player2IsVoted++;
        player1Vote = true;
        if(Game.player2dead == false && Player2Vote.player2Vote == false)
        {
            SceneManager.LoadScene("Player2Vote");
        }
        else if(Game.player3dead == false && Player3Vote.player3Vote == false)
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
        else
        {
            SceneManager.LoadScene("VotingEnd");
        }
    }

    public void voteP3()
    {
        Game.player3IsVoted++;
        player1Vote = true;
        if (Game.player2dead == false && Player2Vote.player2Vote == false)
        {
            SceneManager.LoadScene("Player2Vote");
        }
        else if (Game.player3dead == false && Player3Vote.player3Vote == false)
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
        else
        {
            SceneManager.LoadScene("VotingEnd");
        }
    }

    public void voteP4()
    {
        Game.player4IsVoted++;
        player1Vote = true;
        if (Game.player2dead == false && Player2Vote.player2Vote == false)
        {
            SceneManager.LoadScene("Player2Vote");
        }
        else if (Game.player3dead == false && Player3Vote.player3Vote == false)
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
        else
        {
            SceneManager.LoadScene("VotingEnd");
        }
    }

    public void voteP5()
    {
        Game.player5IsVoted++;
        player1Vote = true;
        if (Game.player2dead == false && Player2Vote.player2Vote == false)
        {
            SceneManager.LoadScene("Player2Vote");
        }
        else if (Game.player3dead == false && Player3Vote.player3Vote == false)
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
        else
        {
            SceneManager.LoadScene("VotingEnd");
        }
    }

}

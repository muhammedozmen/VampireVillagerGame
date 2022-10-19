using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Voting : MonoBehaviour
{
    private void Start()
    {
        Game.playerAliveCount--;
        if (Game.playerAliveCount == 1)
        {
            SceneManager.LoadScene("End");
        }
        else
        {
            if (Game.player1alive == false)
            {
                Game.player1dead = true;
            }
            if (Game.player2alive == false)
            {
                Game.player2dead = true;
            }
            if (Game.player3alive == false)
            {
                Game.player3dead = true;
            }
            if (Game.player4alive == false)
            {
                Game.player4dead = true;
            }
            if (Game.player5alive == false)
            {
                Game.player5dead = true;
            }
        }
        


    }

    public void startVote()
    {
        if (Game.player1dead == false)
        {
            SceneManager.LoadScene("Player1Vote");
        }
        else if (Game.player2dead == false)
        {
            SceneManager.LoadScene("Player2Vote");
        }
        else if (Game.player3dead == false)
        {
            SceneManager.LoadScene("Player3Vote");
        }
        else if (Game.player4dead == false)
        {
            SceneManager.LoadScene("Player4Vote");
        }
        else if (Game.player5dead == false)
        {
            SceneManager.LoadScene("Player5Vote");
        }
    }

    public void NextNight()
    {
        Game.readyCount = 0;
        Player1Vote.player1Vote = false;
        Player2Vote.player2Vote = false;
        Player3Vote.player3Vote = false;
        Player4Vote.player4Vote = false;
        Player5Vote.player5Vote = false;
        Game.player1IsVoted = 0;
        Game.player2IsVoted = 0;
        Game.player3IsVoted = 0;
        Game.player4IsVoted = 0;
        Game.player5IsVoted = 0;
        if (Game.player1alive)
        {
            if(Game.player2alive || Game.player3alive || Game.player4alive || Game.player5alive)
            {
                SceneManager.LoadScene("Player1-");
            }
            else
                SceneManager.LoadScene("EndScene");
        }
        else if (Game.player2alive)
        {
            if (Game.player1alive || Game.player3alive || Game.player4alive || Game.player5alive)
            {
                SceneManager.LoadScene("Player2-");
            }
            else
                SceneManager.LoadScene("EndScene");
        }
        else if (Game.player3alive)
        {
            if (Game.player1alive || Game.player2alive || Game.player4alive || Game.player5alive)
            {
                SceneManager.LoadScene("Player3-");
            }
            else
                SceneManager.LoadScene("EndScene");
        }
        else if (Game.player4alive)
        {
            if (Game.player1alive || Game.player2alive || Game.player3alive || Game.player5alive)
            {
                SceneManager.LoadScene("Player4-");
            }
            else
                SceneManager.LoadScene("EndScene");
        }
        else if (Game.player5alive)
        {
            if (Game.player1alive || Game.player2alive || Game.player3alive || Game.player4alive)
            {
                SceneManager.LoadScene("Player5-");
            }
            else
                SceneManager.LoadScene("EndScene");
        }
        else
            SceneManager.LoadScene("EndScene");
    }
}

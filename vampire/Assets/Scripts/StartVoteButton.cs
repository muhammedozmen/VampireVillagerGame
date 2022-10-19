using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartVoteButton : MonoBehaviour
{
    public void startVote()
    {
        if(Game.player1alive)
        {
            SceneManager.LoadScene("Player1Vote");
        }
        else if(Game.player2alive)
        {
            SceneManager.LoadScene("Player2Vote");
        }
        else if (Game.player3alive)
        {
            SceneManager.LoadScene("Player3Vote");
        }
        else if (Game.player4alive)
        {
            SceneManager.LoadScene("Player4Vote");
        }
        else if (Game.player5alive)
        {
            SceneManager.LoadScene("Player5Vote");
        }
    }
}

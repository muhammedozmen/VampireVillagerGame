using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VoteResult : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI voteResult;

    // Start is called before the first frame update
    void Start()
    {
        if((Game.player1IsVoted > Game.player2IsVoted) && (Game.player1IsVoted > Game.player3IsVoted) &&
           (Game.player1IsVoted > Game.player4IsVoted) && (Game.player1IsVoted > Game.player5IsVoted ) )
        {
            if (Player1Scene.player1vampire)
            {
                Game.player1dead = true;
                SceneManager.LoadScene("End");
            }
            else
            {
                Game.player1dead = true;
                voteResult.text = "Player 1 is hanged.";
            }            
        }
        else if((Game.player2IsVoted > Game.player1IsVoted) && (Game.player2IsVoted > Game.player3IsVoted) &&
           (Game.player2IsVoted > Game.player4IsVoted) && (Game.player2IsVoted > Game.player5IsVoted))
        {
            if (Player2Scene.player2vampire)
            {
                Game.player2dead = true;
                SceneManager.LoadScene("End");
            }
            else
            {
                Game.player2dead = true;
                voteResult.text = "Player 2 is hanged.";
            }
        }
        else if ((Game.player3IsVoted > Game.player1IsVoted) && (Game.player3IsVoted > Game.player2IsVoted) &&
           (Game.player3IsVoted > Game.player4IsVoted) && (Game.player3IsVoted > Game.player5IsVoted))
        {
            if (Player3Scene.player3vampire)
            {
                Game.player3dead = true;
                SceneManager.LoadScene("End");
            }
            else
            {
                Game.player3dead = true;
                voteResult.text = "Player 3 is hanged.";
            }
        }
        else if ((Game.player4IsVoted > Game.player1IsVoted) && (Game.player4IsVoted > Game.player2IsVoted) &&
           (Game.player4IsVoted > Game.player3IsVoted) && (Game.player4IsVoted > Game.player5IsVoted))
        {
            if (Player4Scene.player4vampire)
            {
                Game.player4dead = true;
                SceneManager.LoadScene("End");
            }
            else
            {
                Game.player4dead = true;
                voteResult.text = "Player 4 is hanged.";
            }
        }
        else if ((Game.player5IsVoted > Game.player1IsVoted) && (Game.player5IsVoted > Game.player2IsVoted) &&
           (Game.player5IsVoted > Game.player3IsVoted) && (Game.player5IsVoted > Game.player4IsVoted))
        {
            if (Player5Scene.player5vampire)
            {
                Game.player5dead = true;
                SceneManager.LoadScene("End");
            }
            else
            {
                Game.player5dead = true;
                voteResult.text = "Player 5 is hanged.";
            }
        }
        else
        {
            Game.playerAliveCount++;
            voteResult.text = "Nobody is hanged.";
        }

    }

    
}

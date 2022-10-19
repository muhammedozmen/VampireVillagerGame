using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI winner;

    private void Start()
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

        if (Game.playerAliveCount > 2)
        {
            winner.text = "Villagers won!";
        }
        else
        {            
            if (Game.player1dead == false && Player1Scene.player1vampire)
            {
                winner.text = "Player1 won!";
            }
            else if (Game.player2dead == false && Player2Scene.player2vampire)
            {
                winner.text = "Player2 won!";
            }
            else if (Game.player3dead == false && Player3Scene.player3vampire)
            {
                winner.text = "Player3 won!";
            }
            else if (Game.player4dead == false && Player4Scene.player4vampire)
            {
                winner.text = "Player4 won!";
            }
            else if (Game.player5dead == false && Player5Scene.player5vampire)
            {
                winner.text = "Player5 won!";
            }
            else
                winner.text = "Nobody won!";
        }
    }

    public void Next()
    {
        Game.player1alive = true;
        Game.player2alive = true;
        Game.player3alive = true;
        Game.player4alive = true;
        Game.player5alive = true;
        Player1Scene.player1vampire = false;
        Player2Scene.player2vampire = false;
        Player3Scene.player3vampire = false;
        Player4Scene.player4vampire = false;
        Player5Scene.player5vampire = false;
        Game.readyCount = 0;
        Game.playerAliveCount = 5;
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
        Game.player1dead = false;
        Game.player2dead = false;
        Game.player3dead = false;
        Game.player4dead = false;
        Game.player5dead = false;
        if (Game.isGameStarted == true)
        {
            Game.isGameStarted = false;
            Game.index = 0;
            SceneManager.LoadScene("Menu");
        }
        
    }


}

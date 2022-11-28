using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player5Scene : MonoBehaviour
{
    public static bool player5vampire;
    
    [SerializeField] TextMeshProUGUI playerRole;


    private void Start()
    {


        if (player5vampire == false)
        {
            GameObject.Find("RoleImage").SetActive(true);
            GameObject.Find("RoleImage2").SetActive(false);
            playerRole.text = "You are a Villager! You should discuss with other players who could be vampire and decide on a player to hang.";
            GameObject.Find("Button").SetActive(false);
            GameObject.Find("Button2").SetActive(false);
            GameObject.Find("Button3").SetActive(false);
            GameObject.Find("Button4").SetActive(false);
        }
        else
        {
            GameObject.Find("RoleImage").SetActive(false);
            GameObject.Find("RoleImage2").SetActive(true);
            playerRole.text = "You are a Vampire! Select a player to kill.";
            GameObject.Find("NextButton").SetActive(false);

            if (Game.player1dead == true)
            {
                GameObject.Find("Button").SetActive(false);
            }
            if (Game.player2dead == true)
            {
                GameObject.Find("Button2").SetActive(false);
            }
            if (Game.player3dead == true)
            {
                GameObject.Find("Button3").SetActive(false);
            }
            if (Game.player4dead == true)
            {
                GameObject.Find("Button4").SetActive(false);
            }
        }

        
    }

    



    public void killp1()
    {
        if (player5vampire == true)
        {
            if (Game.player1dead == false)
            {
                Game.readyCount++;
                if (Game.readyCount == Game.playerAliveCount)
                {
                    Game.player1alive = false;
                    SceneManager.LoadScene("Voting");
                }
                else
                {
                    if (Game.player1dead == false)
                    {
                        Game.player1alive = false;
                        SceneManager.LoadScene("Player1-");

                    }
                    else if (Game.player2dead == false)
                    {
                        Game.player1alive = false;
                        SceneManager.LoadScene("Player2-");
                    }
                    else if (Game.player3dead == false)
                    {
                        Game.player1alive = false;
                        SceneManager.LoadScene("Player3-");
                    }
                    else if (Game.player4dead == false)
                    {
                        Game.player1alive = false;
                        SceneManager.LoadScene("Player4-");
                    }
                }
            }
            else
                SceneManager.LoadScene("End");
        }
    }
    public void killp2()
    {
        if (player5vampire == true)
        {
            if (Game.player2dead == false)
            {
                Game.readyCount++;
                if (Game.readyCount == Game.playerAliveCount)
                {
                    Game.player2alive = false;
                    SceneManager.LoadScene("Voting");
                }
                else
                {
                    if (Game.player1dead == false)
                    {
                        Game.player2alive = false;
                        SceneManager.LoadScene("Player1-");

                    }
                    else if (Game.player2dead == false)
                    {
                        Game.player2alive = false;
                        SceneManager.LoadScene("Player2-");
                    }
                    else if (Game.player3dead == false)
                    {
                        Game.player2alive = false;
                        SceneManager.LoadScene("Player3-");
                    }
                    else if (Game.player4dead == false)
                    {
                        Game.player2alive = false;
                        SceneManager.LoadScene("Player4-");
                    }
                }
            }
            else
                SceneManager.LoadScene("End");
        }
    }
    public void killp3()
    {
        if (player5vampire == true)
        {
            if (Game.player3dead == false)
            {
                Game.readyCount++;
                if (Game.readyCount == Game.playerAliveCount)
                {
                    Game.player3alive = false;
                    SceneManager.LoadScene("Voting");
                }
                else
                {
                    if (Game.player1dead == false)
                    {
                        Game.player3alive = false;
                        SceneManager.LoadScene("Player1-");

                    }
                    else if (Game.player2dead == false)
                    {
                        Game.player3alive = false;
                        SceneManager.LoadScene("Player2-");
                    }
                    else if (Game.player3dead == false)
                    {
                        Game.player3alive = false;
                        SceneManager.LoadScene("Player3-");
                    }
                    else if (Game.player4dead == false)
                    {
                        Game.player3alive = false;
                        SceneManager.LoadScene("Player4-");
                    }
                }
            }
            else
                SceneManager.LoadScene("End");
        }
    }
    public void killp4()
    {
        if (player5vampire == true)
        {
            if (Game.player4dead == false)
            {
                Game.readyCount++;
                if (Game.readyCount == Game.playerAliveCount)
                {
                    Game.player4alive = false;
                    SceneManager.LoadScene("Voting");
                }
                else
                {
                    if (Game.player1dead == false)
                    {
                        Game.player4alive = false;
                        SceneManager.LoadScene("Player1-");

                    }
                    else if (Game.player2dead == false)
                    {
                        Game.player4alive = false;
                        SceneManager.LoadScene("Player2-");
                    }
                    else if (Game.player3dead == false)
                    {
                        Game.player4alive = false;
                        SceneManager.LoadScene("Player3-");
                    }
                    else if (Game.player4dead == false)
                    {
                        Game.player4alive = false;
                        SceneManager.LoadScene("Player4-");
                    }
                }
            }
            else
                SceneManager.LoadScene("End");
        }
    }

    public void nextPlayer()
    {
        if (Game.player1dead == false)
        {
            Game.readyCount++;
            if (Game.readyCount == Game.playerAliveCount)
            {
                SceneManager.LoadScene("Voting");
            }
            else
                SceneManager.LoadScene("Player1-");
            
        }
        else if (Game.player2dead == false)
        {
            Game.readyCount++;
            if (Game.readyCount == Game.playerAliveCount)
            {
                SceneManager.LoadScene("Voting");
            }
            else
                SceneManager.LoadScene("Player2-");
            
        }
        else if (Game.player3dead == false)
        {
            Game.readyCount++;
            if (Game.readyCount == Game.playerAliveCount)
            {
                SceneManager.LoadScene("Voting");
            }
            else
                SceneManager.LoadScene("Player3-");
            
        }
        else if (Game.player4dead == false)
        {
            Game.readyCount++;
            if (Game.readyCount == Game.playerAliveCount)
            {
                SceneManager.LoadScene("Voting");
            }
            else
                SceneManager.LoadScene("Player4-");
            
        }
        else
            SceneManager.LoadScene("End");
    }

    
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1Scene : MonoBehaviour
{
    public static bool player1vampire;
    
    [SerializeField] TextMeshProUGUI playerRole;

    private void Start()
    {
        if (player1vampire == false)
        {
            playerRole.text = "You are a Villager! You should discuss with other players who could be vampire and decide on a player to hang.";
            GameObject.Find("Button").SetActive(false);
            GameObject.Find("Button2").SetActive(false);
            GameObject.Find("Button3").SetActive(false);
            GameObject.Find("Button4").SetActive(false);           
        }
        else
        {
            playerRole.text = "You are a Vampire! Select a player to kill.";
            GameObject.Find("NextButton").SetActive(false);

            if (Game.player2dead == true)
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

    }

    
    
    
        

   



    public void killp2()
    {
        if (player1vampire == true)
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
                    Game.player2alive = false;
                    SceneManager.LoadScene("Player2-");
                    
                }
                    

                
            }           
            else
                SceneManager.LoadScene("End");
        }
    }
    public void killp3()
    {
        if (player1vampire == true)
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
                    if (Game.player2dead == false)
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
                    else if (Game.player5dead == false)
                    {
                        Game.player3alive = false;
                        SceneManager.LoadScene("Player5-");
                    }
                }                                  
            }
            else
                SceneManager.LoadScene("End");
        }
    }
    public void killp4()
    {
        if (player1vampire == true)
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
                    if (Game.player2dead == false)
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
                    else if (Game.player5dead == false)
                    {
                        Game.player4alive = false;
                        SceneManager.LoadScene("Player5-");
                    }
                }
            }
            else
                SceneManager.LoadScene("End");
        }
    }
    public void killp5()
    {
        if (player1vampire == true)
        {
            if (Game.player5dead == false)
            {
                Game.readyCount++;
                if (Game.readyCount == Game.playerAliveCount)
                {
                    Game.player5alive = false;
                    SceneManager.LoadScene("Voting");
                }
                else
                {
                    if (Game.player2dead == false)
                    {
                        Game.player5alive = false;
                        SceneManager.LoadScene("Player2-");

                    }
                    else if (Game.player3dead == false)
                    {
                        Game.player5alive = false;
                        SceneManager.LoadScene("Player3-");
                    }
                    else if (Game.player4dead == false)
                    {
                        Game.player5alive = false;
                        SceneManager.LoadScene("Player4-");
                    }
                    else if (Game.player5dead == false)
                    {
                        Game.player5alive = false;
                        SceneManager.LoadScene("Player5-");
                    }
                }
            }
            else
                SceneManager.LoadScene("End");
        }
    }

    public void nextPlayer()
    {
        
        if (Game.player2dead == false)
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
        else if (Game.player5dead == false)
        {
            Game.readyCount++;
            if (Game.readyCount == Game.playerAliveCount)
            {
                SceneManager.LoadScene("Voting");
            }
            else
                SceneManager.LoadScene("Player5-");
            
        }
        else
            SceneManager.LoadScene("End");

    }

    

    



}

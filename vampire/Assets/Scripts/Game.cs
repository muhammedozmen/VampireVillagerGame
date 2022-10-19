using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Game : MonoBehaviour
{
    public static bool player1alive = true;
    public static bool player2alive = true;
    public static bool player3alive = true;
    public static bool player4alive = true;
    public static bool player5alive = true;
    public static bool player1dead = false;
    public static bool player2dead = false;
    public static bool player3dead = false;
    public static bool player4dead = false;
    public static bool player5dead = false;
    public static bool isGameStarted = false;
    public static int player1IsVoted = 0;
    public static int player2IsVoted = 0;
    public static int player3IsVoted = 0;
    public static int player4IsVoted = 0;
    public static int player5IsVoted = 0;
    public static int readyCount = 0;
    public static int playerAliveCount = 5;
    public static int index;
    Random rnd = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("p1").SetActive(!player1dead);
        GameObject.Find("p2").SetActive(!player2dead);
        GameObject.Find("p3").SetActive(!player3dead);
        GameObject.Find("p4").SetActive(!player4dead);
        GameObject.Find("p5").SetActive(!player5dead);

        index = rnd.Next(1, 6);

        if (isGameStarted == false)
        {
         
            if (index == 1)
            {
                Player1Scene.player1vampire = true;
            }
            else if (index == 2)
            {
                Player2Scene.player2vampire = true;
            }
            else if (index == 3)
            {
                Player3Scene.player3vampire = true;
            }
            else if (index == 4)
            {
                Player4Scene.player4vampire = true;
            }
            else if (index == 5)
            {
                Player5Scene.player5vampire = true;
            }
            else
                Debug.Log("Vampire couldnt be selected.");
        }
        












    }
}

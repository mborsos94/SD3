﻿//Authors: Kodey Boreo and Marshall Borsos
using UnityEngine;
using System.Collections;

//Contains global variables used to store information about the game state
public class DataContainer : ScriptableObject {
	public static bool computerLogic;		//Enable or disables computer logic (True = enabled, False = disabled)
    public static PlayerInfo[] players;     //Array which stores player information (name and character icon)
    public static int numOfMoves;           //Total number of moves
    public static GameObject turnPrompt;    //Stores object in UI which denotes which player's turn it is
    public static GameObject winPrompt;     //Stores object in UI which denotes who won or if it is a cat's game
    public static int playerTurn;           //Tracks whose turn it is (0 = player 1; 1 = player 2)
    public static int[,] playerMoves;       /*Array which stores all player movements (0 = empty tile; 1 = player 1 character in tile;
                                              2 = player 2 character in tile*/
    public static Sprite player1Sprite;     //Icon that represents player 1
    public static Sprite player2Sprite;     //Icon that represents player 2
}

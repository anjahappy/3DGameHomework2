using UnityEngine;
using System.Collections;

public class TicTacToe : MonoBehaviour
{

    private int turn = 1;    //1 - Player 1, 0 - Player 2 
    private int[,] board = new int[3, 3];
    private int result = 0;  //0代表未完成，1 - 1 wins，2-2 wins，3-平局

    //棋子
    public Texture2D background;
    public Texture2D img1;
    public Texture2D img2;

    // Use this for initialization 
    void Reset()
    {
        result = 0;
        turn = 1;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = 0;
            }
        }
    }

    void Start()
    {
        Reset();
    }

    void OnGUI()
    {

        //Welcome's fontstyle
        GUIStyle fontStyle = new GUIStyle();
        fontStyle.normal.background = null;
        fontStyle.normal.textColor = new Color(0, 0, 0);
        fontStyle.fontSize = 20;

        //Result's fontstyle
        GUIStyle fontStyle2 = new GUIStyle();
        fontStyle2.normal.background = null;
        fontStyle2.normal.textColor = new Color(1, 0, 1);
        fontStyle2.fontSize = 15;

        //Players & turns' fontstyle
        GUIStyle fontStyle3 = new GUIStyle();
        fontStyle3.normal.background = null;
        fontStyle3.normal.textColor = new Color(0, 0, 1);
        fontStyle3.fontSize = 15;

        //dots' fontstyle
        GUIStyle fontStyle4 = new GUIStyle();
        fontStyle4.normal.background = null;
        fontStyle4.normal.textColor = new Color(0, 0, 1);
        fontStyle4.fontSize = 40;

        GUI.Label(new Rect(0, 0, 512, 512), background);

        //Welcome slogan
        GUI.Label(new Rect(40, 15, 100, 100), "TicTacToe", fontStyle);

        //Show the Players
        GUI.Label(new Rect(50, 50, 50, 50), img1);
        GUI.Label(new Rect(100, 70, 100, 50), "Player1", fontStyle3);
        GUI.Label(new Rect(50, 120, 50, 50), img2);
        GUI.Label(new Rect(100, 140, 100, 50), "Player2", fontStyle3);

        //Show the turns
        if (turn == 1)
        {
            GUI.Label(new Rect(30, 50, 100, 50), ">", fontStyle4);
        }
        else
        {
            GUI.Label(new Rect(30, 120, 100, 50), ">", fontStyle4);
        }

        //Reset button
        if (GUI.Button(new Rect(400, 150, 70, 50), "RESET"))
            Reset();

        // Show the board
        for (int i = 0; i < 3; ++i)
        {
            for (int j = 0; j < 3; ++j)
            {
                if (board[i, j] == 1)
                    GUI.Button(new Rect(210 + i * 50, 40 + j * 50, 50, 50), img1);
                if (board[i, j] == 2)
                    GUI.Button(new Rect(210 + i * 50, 40 + j * 50, 50, 50), img2);
                if (GUI.Button(new Rect(210 + i * 50, 40 + j * 50, 50, 50), ""))
                {
                    if (result == 0)
                    {
                        if (turn == 1)
                            board[i, j] = 1;
                        else
                            board[i, j] = 2;
                        turn = 1 - turn;
                    }
                }
            }
        }

        //Show the result
        GUI.Label(new Rect(50, 185, 100, 50), "Result:", fontStyle2);
        result = check();
        if (result == 1)
        {
            GUI.Label(new Rect(105, 185, 100, 50), "Player1 wins!", fontStyle2);
        }
        else if (result == 2)
        {
            GUI.Label(new Rect(105, 185, 100, 50), "Player2 wins!", fontStyle2);
        }
        else if (result == 3)
        {
            GUI.Label(new Rect(105, 185, 100, 50), "No one wins", fontStyle2);
        }
        else
        {
            GUI.Label(new Rect(105, 185, 100, 50), "Playing...", fontStyle2);
        }


    }
    //Check the result
    int check()
    {
        int count = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] != 0)
                    count++;
            }
        }
        for (int i = 0; i < 3; ++i)//横行
        {
            if (board[i, 0] != 0 && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
            {
                return board[i, 0];
            }
        }
        for (int j = 0; j < 3; ++j)//纵行
        {
            if (board[0, j] != 0 && board[0, j] == board[1, j] && board[1, j] == board[2, j])
            {
                return board[0, j];
            }
        }
        if (board[1, 1] != 0 &&
            board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] ||
            board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
        {
            return board[1, 1];
        }
        if (count == 9)
            return 3;
        return 0;
    }
}

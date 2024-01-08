using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TicTacToeScript : MonoBehaviour
{
    private Boolean gameChecker;
    private int playerScoreAdd;

    // This is to input X and O
    public Text buttonText1 = null;
    public Text buttonText2 = null;
    public Text buttonText3 = null;
    public Text buttonText4 = null;
    public Text buttonText5 = null;
    public Text buttonText6 = null;
    public Text buttonText7 = null;
    public Text buttonText8 = null;
    public Text buttonText9 = null;

    // Menu Buttons
    public Text resetButton = null;
    public Text newGameButton = null;
    public Text feedbackMessage = null;

    // Players
    public Text player1;
    public Text player2;

    public void playerScore()
    {
        // Player 1

        // Going Horizontal
        if (buttonText1.text == "X" && buttonText2.text == "X" && buttonText3.text == "X")
        {
            buttonText1.color = Color.red;
            buttonText2.color = Color.red;
            buttonText3.color = Color.red;

            feedbackMessage.text = "Player 1 has won!";

            playerScoreAdd = int.Parse(player1.text);

            player1.text = Convert.ToString(playerScoreAdd + 1);
        }
        if (buttonText4.text == "X" && buttonText5.text == "X" && buttonText6.text == "X")
        {
            buttonText4.color = Color.red;
            buttonText5.color = Color.red;
            buttonText6.color = Color.red;

            feedbackMessage.text = "Player 1 has won!";

            playerScoreAdd = int.Parse(player1.text);

            player1.text = Convert.ToString(playerScoreAdd + 1);
        }
        if (buttonText7.text == "X" && buttonText8.text == "X" && buttonText9.text == "X")
        {
            buttonText7.color = Color.red;
            buttonText8.color = Color.red;
            buttonText9.color = Color.red;

            feedbackMessage.text = "Player 1 has won!";

            playerScoreAdd = int.Parse(player1.text);

            player1.text = Convert.ToString(playerScoreAdd + 1);
        }

        // Going Vertical
        if (buttonText1.text == "X" && buttonText4.text == "X" && buttonText7.text == "X")
        {
            buttonText1.color = Color.cyan;
            buttonText4.color = Color.cyan;
            buttonText7.color = Color.cyan;

            feedbackMessage.text = "Player 1 has won!";

            playerScoreAdd = int.Parse(player1.text);

            player1.text = Convert.ToString(playerScoreAdd + 1);
        }
        if (buttonText2.text == "X" && buttonText5.text == "X" && buttonText8.text == "X")
        {
            buttonText2.color = Color.cyan;
            buttonText5.color = Color.cyan;
            buttonText8.color = Color.cyan;

            feedbackMessage.text = "Player 1 has won!";

            playerScoreAdd = int.Parse(player1.text);

            player1.text = Convert.ToString(playerScoreAdd + 1);
        }
        if (buttonText3.text == "X" && buttonText6.text == "X" && buttonText9.text == "X")
        {
            buttonText3.color = Color.cyan;
            buttonText6.color = Color.cyan;
            buttonText9.color = Color.cyan;

            feedbackMessage.text = "Player 1 has won!";

            playerScoreAdd = int.Parse(player1.text);

            player1.text = Convert.ToString(playerScoreAdd + 1);
        }

        // Going Diagonal
        if (buttonText1.text == "X" && buttonText5.text == "X" && buttonText9.text == "X")
        {
            buttonText1.color = Color.red;
            buttonText5.color = Color.red;
            buttonText9.color = Color.red;

            feedbackMessage.text = "Player 1 has won!";

            playerScoreAdd = int.Parse(player1.text);

            player1.text = Convert.ToString(playerScoreAdd + 1);
        }
        if (buttonText3.text == "X" && buttonText5.text == "X" && buttonText7.text == "X")
        {
            buttonText3.color = Color.cyan;
            buttonText5.color = Color.cyan;
            buttonText7.color = Color.cyan;

            feedbackMessage.text = "Player 1 has won!";

            playerScoreAdd = int.Parse(player1.text);

            player1.text = Convert.ToString(playerScoreAdd + 1);
        }


        // Player 2

        // Going Horizontal
        if (buttonText1.text == "O" && buttonText2.text == "O" && buttonText3.text == "O")
        {
            buttonText1.color = Color.red;
            buttonText2.color = Color.red;
            buttonText3.color = Color.red;

            feedbackMessage.text = "Player 2 has won!";

            playerScoreAdd = int.Parse(player2.text);

            player2.text = Convert.ToString(playerScoreAdd + 1);
        }
        if (buttonText4.text == "O" && buttonText5.text == "O" && buttonText6.text == "O")
        {
            buttonText4.color = Color.red;
            buttonText5.color = Color.red;
            buttonText6.color = Color.red;

            feedbackMessage.text = "Player 2 has won!";

            playerScoreAdd = int.Parse(player2.text);

            player2.text = Convert.ToString(playerScoreAdd + 1);
        }
        if (buttonText7.text == "O" && buttonText8.text == "O" && buttonText9.text == "O")
        {
            buttonText7.color = Color.red;
            buttonText8.color = Color.red;
            buttonText9.color = Color.red;

            feedbackMessage.text = "Player 2 has won!";

            playerScoreAdd = int.Parse(player2.text);

            player2.text = Convert.ToString(playerScoreAdd + 1);
        }

        // Going Vertical
        if (buttonText1.text == "O" && buttonText4.text == "O" && buttonText7.text == "O")
        {
            buttonText1.color = Color.cyan;
            buttonText4.color = Color.cyan;
            buttonText7.color = Color.cyan;

            feedbackMessage.text = "Player 2 has won!";

            playerScoreAdd = int.Parse(player2.text);

            player2.text = Convert.ToString(playerScoreAdd + 1);
        }
        if (buttonText2.text == "O" && buttonText5.text == "O" && buttonText8.text == "O")
        {
            buttonText2.color = Color.cyan;
            buttonText5.color = Color.cyan;
            buttonText8.color = Color.cyan;

            feedbackMessage.text = "Player 2 has won!";

            playerScoreAdd = int.Parse(player2.text);

            player2.text = Convert.ToString(playerScoreAdd + 1);
        }
        if (buttonText3.text == "O" && buttonText6.text == "O" && buttonText9.text == "O")
        {
            buttonText3.color = Color.cyan;
            buttonText6.color = Color.cyan;
            buttonText9.color = Color.cyan;

            feedbackMessage.text = "Player 2 has won!";

            playerScoreAdd = int.Parse(player2.text);

            player2.text = Convert.ToString(playerScoreAdd + 1);
        }

        // Going Diagonal
        if (buttonText1.text == "O" && buttonText5.text == "O" && buttonText9.text == "O")
        {
            buttonText1.color = Color.red;
            buttonText5.color = Color.red;
            buttonText9.color = Color.red;

            feedbackMessage.text = "Player 2 has won!";

            playerScoreAdd = int.Parse(player2.text);

            player2.text = Convert.ToString(playerScoreAdd + 1);
        }
        if (buttonText3.text == "O" && buttonText5.text == "O" && buttonText7.text == "O")
        {
            buttonText3.color = Color.cyan;
            buttonText5.color = Color.cyan;
            buttonText7.color = Color.cyan;

            feedbackMessage.text = "Player 2 has won!";

            playerScoreAdd = int.Parse(player2.text);

            player2.text = Convert.ToString(playerScoreAdd + 1);
        }
    }

    public void buttonText1Click()
    {
        if (gameChecker == false)
        {
            buttonText1.text = "X";
            gameChecker = true;
        }
        else
        {
            buttonText1.text = "O";
            gameChecker = false;
        }

        playerScore();
    }

    public void buttonText2Click()
    {
        if (gameChecker == false)
        {
            buttonText2.text = "X";
            gameChecker = true;
        }
        else
        {
            buttonText2.text = "O";
            gameChecker = false;
        }

        playerScore();
    }

    public void buttonText3Click()
    {
        if (gameChecker == false)
        {
            buttonText3.text = "X";
            gameChecker = true;
        }
        else
        {
            buttonText3.text = "O";
            gameChecker = false;
        }

        playerScore();
    }

    public void buttonText4Click()
    {
        if (gameChecker == false)
        {
            buttonText4.text = "X";
            gameChecker = true;
        }
        else
        {
            buttonText4.text = "O";
            gameChecker = false;
        }

        playerScore();
    }

    public void buttonText5Click()
    {
        if (gameChecker == false)
        {
            buttonText5.text = "X";
            gameChecker = true;
        }
        else
        {
            buttonText5.text = "O";
            gameChecker = false;
        }

        playerScore();
    }

    public void buttonText6Click()
    {
        if (gameChecker == false)
        {
            buttonText6.text = "X";
            gameChecker = true;
        }
        else
        {
            buttonText6.text = "O";
            gameChecker = false;
        }

        playerScore();
    }

    public void buttonText7Click()
    {
        if (gameChecker == false)
        {
            buttonText7.text = "X";
            gameChecker = true;
        }
        else
        {
            buttonText7.text = "O";
            gameChecker = false;
        }

        playerScore();
    }

    public void buttonText8Click()
    {
        if (gameChecker == false)
        {
            buttonText8.text = "X";
            gameChecker = true;
        }
        else
        {
            buttonText8.text = "O";
            gameChecker = false;
        }

        playerScore();
    }

    public void buttonText9Click()
    {
        if (gameChecker == false)
        {
            buttonText9.text = "X";
            gameChecker = true;
        }
        else
        {
            buttonText9.text = "O";
            gameChecker = false;
        }

        playerScore();
    }

    public void resetButtonClick()
    {
        buttonText1.text = "";
        buttonText2.text = "";
        buttonText3.text = "";
        buttonText4.text = "";
        buttonText5.text = "";
        buttonText6.text = "";
        buttonText7.text = "";
        buttonText8.text = "";
        buttonText9.text = "";

        buttonText1.color = Color.black; 
        buttonText2.color = Color.black;
        buttonText3.color = Color.black; 
        buttonText4.color = Color.black;
        buttonText5.color = Color.black; 
        buttonText6.color = Color.black;
        buttonText7.color = Color.black; 
        buttonText8.color = Color.black;
        buttonText9.color = Color.black;
    }

    public void newGameButtonClick()
    {
        resetButtonClick();
        player1.text = "";
        player2.text = "";
    }
}

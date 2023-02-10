using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Lamya.tictactoe
{
    public class Board : MonoBehaviour
    {

        public static Board Instance;

        [SerializeField] private static int size = 3;
        private bool isXTurn = true;
        [SerializeField] private Sprite xSprite;
        [SerializeField] private Sprite oSprite;
        private int count = 0;
        
        private int[,] boardCells = new int[size, size];

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                return;
            }

            Destroy(gameObject);
        }

        private void Start()
        {
            //ask user for size of game//

            for (int i = 0; i < boardCells.GetLength(0); i++)
            {
                for (int j = 0; j < boardCells.GetLength(1); j++)
                    boardCells[i, j] = 0;
            }

        }

        public void CheckTurn(Vector2 pos, Button cell)
        {
            count++;



            if (isXTurn)
            {
                cell.GetComponent<Button>().image.sprite = xSprite;
                boardCells[(int)pos.x, (int)pos.y] = 1;
            }
            else
            {
                cell.GetComponent<Button>().image.sprite = oSprite;
                boardCells[(int)pos.x, (int)pos.y] = -1;
            }


           

            cell.interactable = false;
            isXTurn = !isXTurn;
            CheckWin();

        }


        private void CheckWin()
        {
            int sumRow = 0;
            int sumCol = 0;

            int sumFDiagonal = 0;
            int sumBDiagonal = 0;



            for (int i = 0; i < boardCells.GetLength(0); i++)
            {
                for (int j = 0; j < boardCells.GetLength(0); j++)
                {
                    sumRow += boardCells[i, j];
                    sumCol += boardCells[j, i];
                    sumFDiagonal += boardCells[j, j];

                }

                if (sumRow == boardCells.GetLength(0) || sumCol == boardCells.GetLength(0) || sumFDiagonal == boardCells.GetLength(0))
                {
                    GameOver.Instance.GameEnded(1);
                    return;

                }
                else if (sumRow == -(boardCells.GetLength(0)) || sumCol == -(boardCells.GetLength(0)) || sumFDiagonal == -(boardCells.GetLength(0)))
                {
                    GameOver.Instance.GameEnded(-1);
                    return;

                }


                sumRow = 0;
                sumCol = 0;
                sumFDiagonal = 0;
            }

            //sum of counter diagonal

            int y = boardCells.GetLength(0) - 1;

            for (int j = 0; j < boardCells.GetLength(0); j++)
            {
                sumBDiagonal += boardCells[j, y];

                if (sumBDiagonal == boardCells.GetLength(0))
                {
                    GameOver.Instance.GameEnded(1);
                    return;

                }
                else if (sumBDiagonal == -(boardCells.GetLength(0)))
                {
                    GameOver.Instance.GameEnded(-1);
                    return;

                }
                y--;
            }

            //checking for draw
            if (count >= boardCells.Length)
            {
                GameOver.Instance.GameEnded(0);
                return;
            }

        }

    }
}



/*
 * NOTES FOR THE PROJECT:
 * 
 * #1) Store all the cells in 2D array 
 * #2) Disable the cell if clicked 
 * #3) Check row, column and diagonal 
 *           O =-1 , X =1 ===>> Win Condition either -(arrayLength) or arrayLength;
 * #4) Disable the board once a winner is declared
 * #5) Draw condition if the board is full but no winner
 * #6) Make a UI:
 *    # Main Menu Screen:
 *          Start Button
 *          
 *    # Game Over Screen:
 *          Winner Name
 *          Restart Button
 *          Back to Main Menu Button
 *               
 *          
 *    # Audio and Soundtrack
 *      
 *      
 *     
 *     slider for controlling music and sound:
 *     audio mixer
 *     mastermixer.setfloat
 *     
 *     
 *     
 *     NOTES FROM SAMI'S LECTURE:
 *     
 *     chaching the getcomponent and avoid using it in the method, call it in start
 *     Logger class like ExtentionMethods class uses public static methods
 *            [System.Diagnostic.Conditional("LOG_ENABLED)];
 *            To enable condition: Player Settings > Other Settings > Scripting Defined Symbols > +
 *            
 *     Namespaces are like packages naming them is like: CompanyName.ProjectName
 */

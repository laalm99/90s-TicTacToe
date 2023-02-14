using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Lamya.tictactoe
{
    [RequireComponent(typeof(Button))]
    public class Cell : MonoBehaviour
    {
        [SerializeField] private Vector2 cellPosition;
        [SerializeField] private Button button;

        public void CellClicked()
        {
            Board.Instance.CheckTurn(cellPosition, button);

        }

    }
}


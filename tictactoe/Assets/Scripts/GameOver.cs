using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


namespace Lamya.tictactoe
{
    public class GameOver : MonoBehaviour
    {
        public static GameOver Instance;
        [SerializeField] private GameObject Xsprite;
        [SerializeField] private GameObject Osprite;
        [SerializeField] private GameObject elementsWin;
        [SerializeField] private GameObject elementsDraw;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
                Destroy(gameObject);
        }

        public void GameEnded(int winner)
        {
            if (winner == 1)
            {
                Xsprite.SetActive(true);
                elementsWin.SetActive(true);
                LeanTween.scale(elementsWin, Vector3.one, 0.2f);

            }
            else if (winner == -1)
            {
                Osprite.SetActive(true);
                elementsWin.SetActive(true);
                LeanTween.scale(elementsWin, Vector3.one, 0.2f);
            }
            else if (winner == 0)
            {
                elementsDraw.SetActive(true);
                LeanTween.scale(elementsDraw, Vector3.one, 0.2f);
            }
        }

        public void RestartGame()
        {
            SceneManager.LoadScene(1);
        }

        public void MainMenuLoad()
        {
            SceneManager.LoadScene(0);
        }

    }
}


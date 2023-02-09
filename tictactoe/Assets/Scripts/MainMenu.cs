using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Lamya.tictactoe
{
    public class MainMenu : MonoBehaviour
    {
        public void PlayButton()
        {
            SceneManager.LoadScene(1);
        }
    }
}


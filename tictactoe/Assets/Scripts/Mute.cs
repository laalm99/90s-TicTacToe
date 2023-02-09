using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;




namespace Lamya.tictactoe
{
    public class Mute : MonoBehaviour
    {

        [SerializeField] private Sprite muteSprite;
        [SerializeField] private Sprite unmuteSprite;


        private AudioSource audiosource;

        private void Start()
        {
            audiosource = GetComponent<AudioSource>();
        }

        public void Switch()
        {
            if (audiosource.isPlaying)
            {
                audiosource.Pause();
                gameObject.GetComponent<Image>().sprite = unmuteSprite;
            }
            else
            {
                audiosource.Play();
                gameObject.GetComponent<Image>().sprite = muteSprite;
            }
        }

    }
}


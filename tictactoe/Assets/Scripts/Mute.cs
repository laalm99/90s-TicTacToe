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
       

        public void Switch()
        {
            if (Audio.Instance.AudioSource.isPlaying)
            {
                Audio.Instance.AudioSource.Pause();
                gameObject.GetComponent<Image>().sprite = unmuteSprite;
            }
            else
            {
                Audio.Instance.AudioSource.Play();
                gameObject.GetComponent<Image>().sprite = muteSprite;
            }
        }

    }
}


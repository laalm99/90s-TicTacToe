using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Lamya.tictactoe
{
    public class Audio : MonoBehaviour
    {
        public static Audio Instance;
        private AudioSource audioSource;
        public AudioSource AudioSource => audioSource;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
                Destroy(gameObject);
        }


        // Start is called before the first frame update
        void Start()
        {
            DontDestroyOnLoad(this.gameObject);
            audioSource = GetComponent<AudioSource>();
        }

      

    }
}


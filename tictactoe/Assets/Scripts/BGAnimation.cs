using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lamya.tictactoe{
    public class BGAnimation : MonoBehaviour
    {
        [SerializeField] private bool main;
        [SerializeField] private float to;
        [SerializeField] private float time;

        void Start()
        {
            if (main)
                LeanTween.rotate(this.gameObject, new Vector3(0, 0, to), time).setLoopPingPong();
            else
                LeanTween.moveY(GetComponent<RectTransform>(), to, time).setLoopPingPong();
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FootBallAI
{
    public class Door : MonoBehaviour
    {
        public bool isL;

        private void OnCollisionEnter(Collision collision)
        {
            if (isL && collision.gameObject.tag == "Ball")
            {
                var gm = GameManage.GetGM;
                gm.addRightScore();
                collision.gameObject.GetComponent<AudioSource>().Play();
            }
            else if (!isL && collision.gameObject.tag == "Ball")
            {
                var gm = GameManage.GetGM;
                gm.addLeftScore();
                collision.gameObject.GetComponent<AudioSource>().Play();
            }
        }
    }
}

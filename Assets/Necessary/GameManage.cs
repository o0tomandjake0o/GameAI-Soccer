using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace FootBallAI
{

    public class GameManage : MonoBehaviour
    {
        private static GameManage gm;
        public int leftScore { get; private set; } = 0 ;
        public int rightScore { get; private set; } = 0;

        public Ball ball;

        public UnityEvent UpdateLeftScoreEvent;
        public UnityEvent UpdateRightScoreEvent;


        private void Awake()
        {
            gm = this;
        }
        public static GameManage GetGM
        {
            get
            {
                return gm;
            }
        }

        public void addLeftScore()
        {
            leftScore++;
            setOriginal();
            UpdateLeftScoreEvent.Invoke();

            if (leftScore == 5)
            {
                Time.timeScale = 0;
                UIManager.getUI.setWIN(0);
            }
        }

        public void addRightScore()
        {
            rightScore++;
            setOriginal();
            UpdateRightScoreEvent.Invoke();

            if (rightScore == 5)
            {
                Time.timeScale = 0;
                UIManager.getUI.setWIN(1);
            }
        }

        public int getLeftScore
        {
            get{
                return leftScore;
            }
        }
        public int getRightScore
        {
            get
            {
                return rightScore;
            }
        }

        public void setOriginal()
        {
            //foreach(var player in players)
            //{
            //    player.setOriginal();
            //}
            ball.setOri();
        }

        IEnumerator Wait()
        {
            yield return new WaitForSeconds(3f);
        }
    }
}

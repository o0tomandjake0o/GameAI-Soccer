using FootBallAI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text redText, blueText;

    void AddRedScore()
    {
        redText.text = GameManage.GetGM.leftScore.ToString();
        //Debug.Log(GameManage.GetGM.leftScore);
    }

    void AddBlueScore()
    {
        blueText.text = GameManage.GetGM.rightScore.ToString();
        //Debug.Log(GameManage.GetGM.rightScore);

    }

    // Start is called before the first frame update
    void Start()
    {

        GameManage.GetGM.UpdateLeftScoreEvent.AddListener(AddRedScore);
        GameManage.GetGM.UpdateRightScoreEvent.AddListener(AddBlueScore);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

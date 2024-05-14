using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject talkPanel;
    public Text talkText;
    public GameObject scanObject;
    public static GameManager instance;
    public bool isAction;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void Action(GameObject scanObj)
    {
        if (isAction)
        {
            isAction = false;
        }
        else
        {
            isAction = true;
            scanObject = scanObj;
            talkText.text = "이사람의 이름은" + scanObject.name + "이라고 한다.";
        }
        talkPanel.SetActive(isAction);
    }
}

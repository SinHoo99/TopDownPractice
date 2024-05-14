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
            talkText.text = "�̻���� �̸���" + scanObject.name + "�̶�� �Ѵ�.";
        }
        talkPanel.SetActive(isAction);
    }
}

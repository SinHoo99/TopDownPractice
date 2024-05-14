using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;

    private void Awake()
    {
        talkData = new Dictionary<int, string[]>(); // ��ũ ������ �ʱ�ȭ
        GenerateData();
    }

    private void GenerateData()
    {
        talkData.Add(1000, new string[] { "�ȳ�", "�� ���� ó���Ա���?" });
        talkData.Add(100, new string[] { "�׳� �ڽ��Դϴ�." });
        talkData.Add(2000, new string[] { "�� �糪��" });
    }

    public string GetTalk(int id,int talkIndex)
    {
        if(talkIndex == talkData[id].Length)
        {
            return null;
        }
        else
        {
            return talkData[id][talkIndex];
        }   
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;

    private void Awake()
    {
        talkData = new Dictionary<int, string[]>(); // 토크 데이터 초기화
        GenerateData();
    }

    private void GenerateData()
    {
        talkData.Add(1000, new string[] { "안녕", "이 곳엔 처음왔구나?" });
        talkData.Add(100, new string[] { "그냥 박스입니다." });
        talkData.Add(2000, new string[] { "난 루나야" });
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

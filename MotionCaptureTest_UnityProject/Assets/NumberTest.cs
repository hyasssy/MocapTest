using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text.RegularExpressions;

public class NumberTest : MonoBehaviour
{
    void Start()
    {
        string s = "0.71583, -29.48274";
        MatchCollection matches = Regex.Matches(s, @"-?\d+[.]\d+");
        foreach(Match match in matches){
            Debug.Log(match.Index);//キャプチャした部分文字列の最初の文字が見つかる元の文字列内の位置。
            Debug.Log(match.Value);
        }
        double latitude = double.Parse(matches[0].Value);
        double longitude = double.Parse(matches[1].Value);
        Debug.Log(latitude);
        Debug.Log(longitude);
    }
}

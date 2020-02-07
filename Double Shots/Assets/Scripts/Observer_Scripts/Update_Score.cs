using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Update_Score : MonoBehaviour
{
    private TextMeshPro scoreboard;
    // Update is called once per frame
    void Update()
    {
        scoreboard = GetComponent<Observer_Data>().board;

        scoreboard.SetText(GetComponent<Observer_Data>().score.ToString());
    }
}

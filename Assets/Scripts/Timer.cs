using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private TextMeshProUGUI _textTimer;
    private float _currentTime;

    void Start()
    {
        _textTimer = GetComponent<TextMeshProUGUI>();
    }

    private void Update() {
        TimerCounter();
    }

    private void TimerCounter(){
        _currentTime += Time.deltaTime;
        int _minutes = Mathf.FloorToInt(_currentTime / 60);
        int _seconds = Mathf.FloorToInt(_currentTime % 60);
        _textTimer.text = string.Format("{0:00}:{1:00}", _minutes, _seconds);
    }
}

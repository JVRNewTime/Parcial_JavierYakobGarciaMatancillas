using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointCounter : MonoBehaviour
{
    private TextMeshProUGUI _textPoints;

    void Start()
    {
        _textPoints = GetComponent<TextMeshProUGUI>();
    }

   
    void Update()
    {
        _textPoints.text = "Asteroides: " + GameManager.Instance.points.ToString();
    }
}

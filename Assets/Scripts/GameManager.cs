using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public static GameManager Instance { get; set; }
    [SerializeField] public int points;

    private void Awake() {
        if (Instance == null){
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}

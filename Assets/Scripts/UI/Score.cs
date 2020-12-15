using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreTxt;
    void Start()
    {
        scoreTxt = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        scoreTxt.text = GameManager.Instance.GetScore().ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthScore : MonoBehaviour
{
    public TextMeshProUGUI healthScore;
    [SerializeField] private Player_Life _playerLife;
    void Start()
    {
        healthScore = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        healthScore.text = _playerLife.GetHealth().ToString();
    }
}

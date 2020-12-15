using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score;
    
    private static GameManager instance;
    // Game Instance Singleton
    public static GameManager Instance
    {
        get
        {
            if (instance== null)
                Debug.LogWarning("Game Manager null");
            return instance; 
        }
    }
     
    private void Awake()
    {
        // if the singleton hasn't been initialized yet
        if (instance != null && instance != this)
            Destroy(this.gameObject);
        
        instance = this;
        DontDestroyOnLoad( this.gameObject );
    }

    public int GetScore()
    {
        return score;
    }

    public void AddToScore(int scoreValue)
    {
        score += scoreValue;
    }

    public void Reset()
    {
        Destroy(gameObject);
    }
}

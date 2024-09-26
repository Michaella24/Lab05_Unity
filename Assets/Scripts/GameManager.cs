using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int maxScore = 4;
    public static GameManager Instance;
    void Awake() 
    {
        if (Instance == null) 
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); //will make sure the game manager will stay active between scene loading
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void IncrementScore()
    {
        ++score;
        Debug.Log("Score: "+ score);
        if(score >= maxScore)
        {
            LoadNewScene();
        }
    }

    public void LoadNewScene()
    {
        SceneManager.LoadScene("VictoryScene");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }
    public TextMeshProUGUI scoreText;
    public float HighScore { get; private set; }

    private void Awake()
    {
        
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            scoreText.text = "Sun:" + HighScore.ToString();
        }
        else
        {
            Destroy(gameObject);
        }

        
    }

    public void AddScore(float score)
    {
        HighScore += score;
        Debug.Log("current: " + HighScore);
        scoreText.text = "Sun:" + HighScore.ToString();
    }
}
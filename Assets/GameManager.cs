using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;
    public float timeLeft = 30f;
    public Text scoreText;
    public Text timerText;

    bool gameOver = false;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if (gameOver) return;

        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            timeLeft = 0;
            gameOver = true;
        }

        if (timerText != null) timerText.text = "Time: " + Mathf.CeilToInt(timeLeft);
        if (scoreText != null) scoreText.text = "Score: " + score;
    }

    public void AddScore(int amount)
    {
        if (gameOver) return;
        score += amount;
    }
}
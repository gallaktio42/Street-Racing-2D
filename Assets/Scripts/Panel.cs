using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Panel : MonoBehaviour
{
    public Text highScoreText;
    public Text scoreText;

    public int score;
    public int highScore;

    public Score scoreManage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        highScore = PlayerPrefs.GetInt("high score");
        score = scoreManage.score;

        highScoreText.text = "Highscore: " + highScore.ToString();
        scoreText.text = "Score: " + score.ToString();
    }

    public void Restart()
    {
        SceneManager.LoadScene("save");
    }
}

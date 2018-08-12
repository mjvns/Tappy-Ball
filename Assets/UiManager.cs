using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour {

    public static UiManager instance;

    public GameObject gameOverPanel;
    public GameObject startUI;
    public GameObject gameOverText;

    public Text scoreText;
    public Text highScoreText;

    void Awake()
    {
        if (instance == null) {
            instance = this;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = ScoreManager.instance.score.ToString();
	}

    public void gameStart() {
        startUI.SetActive(false);
    }

    public void gameOver() {
        gameOverText.SetActive(true);
        highScoreText.text = "HIGH SCORE: " + PlayerPrefs.GetInt("HighScore").ToString();
        gameOverPanel.SetActive(true);
    }

    public void replay() {
        SceneManager.LoadScene("Level1");
    }

    public void menu() {
        SceneManager.LoadScene("Menu");
    }
}

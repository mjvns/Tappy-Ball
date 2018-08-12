using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    bool gameover;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (instance == null)
        {
            instance = this;
        }
        else {
            Destroy(this.gameObject);
        }
    }

    // Use this for initialization
    void Start () {
        gameover = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void gameStart() {
        UiManager.instance.gameStart();
        GameObject.Find("PipeSpawner").GetComponent<PipeSpawner>().startSpawningPipes();
    }

    public void gameOver() {
        gameover = false;
        GameObject.Find("PipeSpawner").GetComponent<PipeSpawner>().stopSpawningPipes();
        ScoreManager.instance.stopScore();
        UiManager.instance.gameOver();
    }
}

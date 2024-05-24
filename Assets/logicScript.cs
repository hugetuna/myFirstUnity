using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    //¤À¼Æ
    public int score = 0;
    public Text scoreText;
    public GameObject gameoverScreen;
    [ContextMenu("addScore")]
    public void addScore(int scoreToAdd)
    {
        score = score + scoreToAdd;
        scoreText.text = score.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    [ContextMenu("showGameOver")]
    public void showGameOver()
    {
        gameoverScreen.SetActive(true);
    }
}

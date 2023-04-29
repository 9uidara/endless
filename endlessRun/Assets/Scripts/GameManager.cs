using UnityEngine;
using UnityEngine.UI;
    

public class GameManager : MonoBehaviour {

    int score;
    public static GameManager inst;

    [SerializeField] Text scoreText;

    public void IncrementScore ()
    {
        score++;
        scoreText.text = "SCORE: " + score;
    }

    private void Awake ()
    {
        inst = this;
    }
}
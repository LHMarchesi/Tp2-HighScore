using TMPro;
using UnityEngine;
using UnityEngine.Video;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        currentScore = 0;
        timer = 0;
        squareRed.SetActive(true);
        squareYellow.SetActive(true);
        gameOverScreen.SetActive(false);
        highScoreScreen.SetActive(false);
    }

    [SerializeField] private TextMeshProUGUI currentScoretxt;
    [SerializeField] private HighScoreManager highScoreManager;
    [SerializeField] private HighScoreUI highScoreUI;

    [SerializeField] private GameObject squareRed;
    [SerializeField] private GameObject squareYellow;
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject highScoreScreen;

    private int currentScore;
    private float timer;
    private bool gameOver;
    public int Score { get => currentScore; set => currentScore = value; }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 5 && !gameOver)
        {
            squareRed.SetActive(false);
            squareYellow.SetActive(false);
            gameOverScreen.SetActive(true);
            gameOver = true;
        }
    }

    public void ScoreAddOne()
    {
        currentScore++;
        currentScoretxt.text = currentScore.ToString();
    }

    public void NewHighScore(string name)
    {
        HighScoreElement newHighScore = new HighScoreElement(name, currentScore);
        highScoreManager.AddHighScore(newHighScore);
        highScoreUI.UpdateUI(highScoreManager.HighScoreList);
    }

    public void PlayAgain()
    {
        currentScore = 0;
        timer = 0;
        gameOver = false;
        squareRed.SetActive(true);
        squareYellow.SetActive(true);
    }
}

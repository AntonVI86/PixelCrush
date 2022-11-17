using TMPro;
using UnityEngine;
using Agava.YandexGames;

[RequireComponent(typeof(TMP_Text))]
public class TotalScoreDisplayer : MonoBehaviour
{
    [SerializeField] private ScoreSaver _scoreSaver;

    private TMP_Text _scoreText;

    private void Awake()
    {
        _scoreText = GetComponent<TMP_Text>();
    }
    private void Start()
    {
        Leaderboard.GetPlayerEntry("PixelCrushBoard", (result) =>
        {
            if (result == null)
                Debug.Log("Player is not present in the leaderboard.");
            else
                Debug.Log($"My rank = {result.rank}, score = {result.score}");
        });

        Leaderboard.SetScore("PixelCrushBoard", Random.Range(1, 100));
        _scoreText.text = _scoreSaver.GetScore().ToString();
    }
}

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
        _scoreText.text = _scoreSaver.GetScore().ToString();
    }
}

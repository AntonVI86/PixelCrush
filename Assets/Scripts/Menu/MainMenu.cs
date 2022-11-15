using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _playingButton;

    [SerializeField] private ReseterItems _reseter;

    public const string LevelName = "LevelName";
    public const string StartLevel = "Level1";

    private void OnEnable()
    {
        _restartButton.onClick.AddListener(OnClickRestartButton);
        _playingButton.onClick.AddListener(OnClickPlayingButton);
    }

    private void OnDisable()
    {
        _restartButton.onClick.RemoveListener(OnClickRestartButton);
        _playingButton.onClick.RemoveListener(OnClickPlayingButton);
    }

    private void OnClickRestartButton()
    {
        ResetGame();
    }

    private void OnClickPlayingButton()
    {
        if(PlayerPrefs.HasKey(LevelName))
            SceneManager.LoadScene(PlayerPrefs.GetString(LevelName));
        else
            SceneManager.LoadScene(StartLevel);
    }

    private void ResetGame()
    {
        PlayerPrefs.DeleteAll();

        _reseter.Reset();
    }
}

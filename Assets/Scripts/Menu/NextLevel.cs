using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Agava.YandexGames;
using System.Collections;

[RequireComponent(typeof(Button))]
public class NextLevel : MonoBehaviour
{
    private Button _nextLevel;

    private void Awake()
    {
        _nextLevel = GetComponent<Button>();
    }

    private IEnumerator Start()
    {
        yield return YandexGamesSdk.Initialize();
    }

    private void OnEnable()
    {
        _nextLevel.onClick.AddListener(OnClickNextLevelButton);
    }

    private void OnDisable()
    {
        _nextLevel.onClick.RemoveListener(OnClickNextLevelButton);
    }

    private void OnClickNextLevelButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

using TMPro;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class LevelView : MonoBehaviour
{
    [SerializeField] private TMP_Text _level;
    [SerializeField] private TMP_Text _levelNumber;

    private float _duration = 2f;

    private void Start()
    {
        _levelNumber.text = (SceneManager.GetActiveScene().buildIndex).ToString();
        _level.DOFade(0, _duration).OnComplete(() => gameObject.SetActive(false));
        _levelNumber.DOFade(0, _duration).OnComplete(() => gameObject.SetActive(false));
    }
}

using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(TMP_Text))]
public class TimeScaleChanger : MonoBehaviour
{
    [SerializeField] private Button _button;

    private TMP_Text _textView;

    private void Awake()
    {
        _textView = GetComponent<TMP_Text>();
    }

    public void OnChangeTimeScale()
    {
        Limit();
        Show();
    }

    public void DisableButton()
    {
        _button.interactable = !_button.interactable;
        Show();
    }

    private void Show()
    {
        _textView.text = Time.timeScale + "X";
    }

    private void Limit()
    {
        if (Time.timeScale < 3)
        {
            Time.timeScale++;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}

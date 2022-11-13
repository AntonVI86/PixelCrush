using UnityEngine;
using DG.Tweening;

public class MovingRotator : MonoBehaviour
{
    [SerializeField] private Transform _target;

    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DOMove(_target.position, _duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}

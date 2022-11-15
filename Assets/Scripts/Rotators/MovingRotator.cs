using UnityEngine;
using DG.Tweening;

public class MovingRotator : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Rigidbody2D _rigidbody;

    [SerializeField] private float _duration;

    private void Start()
    {
        _rigidbody.DOMove(_target.position, _duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}

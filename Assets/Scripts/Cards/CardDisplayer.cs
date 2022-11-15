using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CardDisplayer : MonoBehaviour
{
    [SerializeField] private List<CardView> _collection = new List<CardView>();

    [SerializeField] private Spawner _spawner;
    [SerializeField] private Transform _pointOfIncreasePosition;
    [SerializeField] private GameObject _nextButton;

    private void Start()
    {
        _nextButton.SetActive(false);

        ReceiveRandomCardsToChoice();
    }

    public void ReceiveRandomCardsToChoice()
    {
        int cardsOnScreen = 3;

        if (_collection.Count < cardsOnScreen)
        {
            cardsOnScreen = _collection.Count;
        }

        for (int i = 0; i < cardsOnScreen; i++)
        {
            int index = Random.Range(0, _collection.Count);

            CardView newCard = Instantiate(_collection[index], transform);
            
            newCard.Selected += OnSelected;
        }
    }

    private void OnSelected(CardView card)
    {
        _spawner.AddNewItemToNextLevel(card.Item.gameObject);

        card.Selected -= OnSelected;

        AnimateCard(card);

        transform.parent.gameObject.SetActive(false);
        _nextButton.SetActive(true);
    }

    private void AnimateCard(CardView card)
    {
        card.gameObject.transform.SetParent(_pointOfIncreasePosition);
        card.CardTransform.DOMove(_pointOfIncreasePosition.position, 1f).SetUpdate(true);
        card.AnimateCard();
    }
}

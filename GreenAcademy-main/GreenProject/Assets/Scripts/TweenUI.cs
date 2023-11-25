using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TweenUI : MonoBehaviour
{
    [SerializeField] float moveDistance;
    [SerializeField] float moveTime;

    private void Start()
    {
        var moveX = transform.DOMoveX(-moveDistance, moveTime);


        var sequence = DOTween.Sequence();
        sequence
            .Append(moveX)
            .SetLoops(-1)
            .SetEase(Ease.Linear)
            ;
    }
}

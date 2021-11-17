using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TitleTweener : MonoBehaviour
{

    [SerializeField] private Vector3 endScale;
    void Start()
    {
        
        endScale = transform.localScale;
        transform.localScale = new Vector3(0.0001f, 0.0001f, 0.0001f);
        transform.DOScale(endScale, 1f).SetEase(Ease.InCirc);
    }

}

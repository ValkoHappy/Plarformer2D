using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class Coin : MonoBehaviour
{
    [SerializeField] private UnityEvent _entered;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _entered?.Invoke();
        }
    }
}

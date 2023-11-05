using System.Collections;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    [SerializeField] private YandexAdv _yandexAdv;
    [SerializeField] private PointEffector2D _pointEffector2D;
    [SerializeField] private float _time;
    [SerializeField] private long _count = 10;    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(Disabled());
        _yandexAdv.ShowRevarded(_count);
    }

    private IEnumerator Disabled()
    {
        yield return new WaitForSeconds(_time);
        _pointEffector2D.enabled = false;
        _yandexAdv.ShowFullScreen();
    }
}
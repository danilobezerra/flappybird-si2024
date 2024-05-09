using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public SpriteRenderer backgroundNight;
    public float maxTime;
    public bool isNight;

    private float _timer;

    private void Update()
    {
        if (_timer > maxTime)
        {
            SetNight(!isNight);
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }

    private void SetNight(bool value)
    {
        isNight = value;
        backgroundNight.gameObject.SetActive(isNight);
    }
}

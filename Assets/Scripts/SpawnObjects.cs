using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject prefab;
    public float maxHeight;
    public float minHeight;
    public float maxTime = .5f;

    private float _timer;

    private void Start()
    {
        InstantiateObject();
    }

    private void Update()
    {
        if (_timer > maxTime) {
            InstantiateObject();
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }

    private void InstantiateObject()
    {
        var instance = Instantiate(prefab);
        var y = Random.Range(minHeight, maxHeight);
        instance.transform.position
            = transform.position + new Vector3(0, y);

        Destroy(instance, 10f);
    }
}

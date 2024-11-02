using UnityEngine;

public class ColumnSpawner : MonoBehaviour
{
    [SerializeField] private float _maxTime = 1.5f;
    [SerializeField] private float _heightRange = 0.45f;
    [SerializeField] private GameObject _column;

    private float _timer;

    private void Start()
    {
        SpawnColumn();
    }

    private void Update()
    {
        if(_timer > _maxTime)
        {
            SpawnColumn();
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }
    private void SpawnColumn()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange));
        GameObject column = Instantiate(_column, spawnPos, Quaternion.identity);
        Destroy (column, 10f);
    }
}

using UnityEngine;

public sealed class HazardSpawner : MonoBehaviour
{
    [SerializeField] private GameObject hazardPrefab;
    [SerializeField] private float spawnInterval = 0.85f;
    [SerializeField] private float fallSpeed = 4.2f;
    [SerializeField] private Vector2 xRange = new Vector2(-2.8f, 2.8f);

    private float timer;

    public void Configure(GameObject prefab)
    {
        hazardPrefab = prefab;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            SpawnHazard();
            timer = Mathf.Max(0.38f, spawnInterval - GameSessionController.Score * 0.002f);
        }
    }

    public void SpawnHazard()
    {
        if (hazardPrefab == null)
        {
            return;
        }

        Vector3 position = new Vector3(Random.Range(xRange.x, xRange.y), 6.2f, 0f);
        GameObject hazard = Instantiate(hazardPrefab, position, Quaternion.identity);
        hazard.AddComponent<HazardMover>().Initialize(fallSpeed);
    }
}

public sealed class HazardMover : MonoBehaviour
{
    private float speed;

    public void Initialize(float fallSpeed)
    {
        speed = fallSpeed;
    }

    private void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
        if (transform.position.y < -6.5f)
        {
            Destroy(gameObject);
        }
    }
}

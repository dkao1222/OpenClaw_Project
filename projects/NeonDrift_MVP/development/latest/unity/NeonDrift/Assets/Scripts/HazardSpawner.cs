using UnityEngine;

public sealed class HazardSpawner : MonoBehaviour
{
    [SerializeField] private GameObject hazardPrefab;
    [SerializeField] private float spawnInterval = 1.35f;
    [SerializeField] private float initialSpawnDelay = 2.5f;
    [SerializeField] private float fallSpeed = 2.8f;
    [SerializeField] private Vector2 xRange = new Vector2(-2.8f, 2.8f);

    private float timer = 2.5f;

    public void Configure(GameObject prefab)
    {
        hazardPrefab = prefab;
        timer = initialSpawnDelay;
    }

    private void Update()
    {
        GameSessionController session = GameSessionController.Instance != null ? GameSessionController.Instance : FindObjectOfType<GameSessionController>();
        if (session == null || !session.CanSpawnHazards)
        {
            timer = initialSpawnDelay;
            return;
        }

        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            SpawnHazard();
            timer = Mathf.Max(0.75f, spawnInterval - GameSessionController.Score * 0.001f);
        }
    }

    public void SpawnHazard()
    {
        if (hazardPrefab == null)
        {
            return;
        }

        Vector3 position = new Vector3(ChooseReadableSpawnX(), 6.2f, 0f);
        GameObject hazard = Instantiate(hazardPrefab, position, Quaternion.identity);
        hazard.AddComponent<HazardMover>().Initialize(fallSpeed);
    }

    private float ChooseReadableSpawnX()
    {
        GameSessionController session = GameSessionController.Instance != null ? GameSessionController.Instance : FindObjectOfType<GameSessionController>();
        if (session != null && session.GameplayTime < 8f)
        {
            return Random.value < 0.5f ? Random.Range(xRange.x, -1.35f) : Random.Range(1.35f, xRange.y);
        }
        return Random.Range(xRange.x, xRange.y);
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

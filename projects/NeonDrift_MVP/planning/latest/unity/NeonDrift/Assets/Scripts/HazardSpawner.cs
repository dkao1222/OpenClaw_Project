using UnityEngine;

public sealed class HazardSpawner : MonoBehaviour
{
    [SerializeField] private GameObject hazardPrefab;
    [SerializeField] private float spawnInterval = 1.05f;
    [SerializeField] private float initialSpawnDelay = 1.2f;
    [SerializeField] private float fallSpeed = 4.8f;
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
    private Vector3 baseScale;

    public void Initialize(float fallSpeed)
    {
        speed = fallSpeed;
        baseScale = transform.localScale;
    }

    private void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
        float approach = Mathf.InverseLerp(6.2f, -3.6f, transform.position.y);
        transform.localScale = baseScale * Mathf.Lerp(0.75f, 1.35f, approach);
        if (transform.position.y < -6.5f)
        {
            Destroy(gameObject);
        }
    }
}

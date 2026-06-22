using UnityEngine;

public sealed class DriftPlayerController : MonoBehaviour
{
    public static DriftPlayerController Instance { get; private set; }

    [SerializeField] private float acceleration = 18f;
    [SerializeField] private float damping = 0.92f;
    [SerializeField] private float xLimit = 3.1f;

    private Rigidbody2D body;
    private float steer;
    private float uiSteer;

    public float CurrentX => transform.position.x;
    public bool HasUiSteeringInput => Mathf.Abs(uiSteer) > 0.01f;

    private void Awake()
    {
        Instance = this;
        body = GetComponent<Rigidbody2D>();
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    private void Update()
    {
        steer = 0f;
        if (Mathf.Abs(uiSteer) > 0.01f)
        {
            steer = uiSteer;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            steer = -1f;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            steer = 1f;
        }
        if (Input.touchCount > 0)
        {
            steer = Input.GetTouch(0).position.x < Screen.width * 0.5f ? -1f : 1f;
        }
    }

    public void SetUiSteer(float direction)
    {
        uiSteer = Mathf.Clamp(direction, -1f, 1f);
    }

    public void ClearUiSteer()
    {
        uiSteer = 0f;
    }

    public void SimulateSteerStep(float direction, float deltaTime)
    {
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x + direction * acceleration * deltaTime * 0.12f, -xLimit, xLimit);
        transform.position = position;
    }

    private void FixedUpdate()
    {
        Vector2 velocity = body.linearVelocity;
        velocity.x = (velocity.x + steer * acceleration * Time.fixedDeltaTime) * damping;
        body.linearVelocity = velocity;

        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -xLimit, xLimit);
        transform.position = position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Hazard"))
        {
            GameSessionController.Instance?.GameOver();
        }
    }
}

using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private Transform player;

    private Camera mainCamera;
    private float spriteWidth, spriteHeight;

    void Start()
    {
        mainCamera = Camera.main;

        // Get enemy's sprite bounds
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        if (sr != null)
        {
            spriteWidth = sr.bounds.extents.x;
            spriteHeight = sr.bounds.extents.y;
        }
        else
        {
            spriteWidth = 0.5f;
            spriteHeight = 0.5f;
        }
    }

    void Update()
    {
        if (player == null) return;

        // Direction toward player
        Vector3 direction = (player.position - transform.position).normalized;

        // Move toward player
        transform.position += direction * moveSpeed * Time.deltaTime;

        // Keep inside camera bounds
        Vector3 viewPos = mainCamera.WorldToViewportPoint(transform.position);
        bool bounced = false;

        if (viewPos.x < 0f || viewPos.x > 1f)
        {
            viewPos.x = Mathf.Clamp01(viewPos.x);
            bounced = true;
        }

        if (viewPos.y < 0f || viewPos.y > 1f)
        {
            viewPos.y = Mathf.Clamp01(viewPos.y);
            bounced = true;
        }

        if (bounced)
        {
            transform.position = mainCamera.ViewportToWorldPoint(viewPos);
        }
    }
}

using UnityEngine;
using System.Collections;

public class Drive : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;

    [SerializeField] private float dashSpeed = 30.0f;     // Dash burst speed
    [SerializeField] private float dashDuration = 0.2f;   // Duration of dash in seconds

    private bool isDashing = false;

    void Update()
    {
        float moveSpeed = isDashing ? dashSpeed : speed;

        // Movement input
        float translation = Input.GetAxis("Vertical") * moveSpeed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Move and rotate
        transform.Translate(0, translation, 0);
        transform.Rotate(0, 0, -rotation);

        // Dash input
        if (Input.GetKeyDown(KeyCode.LeftShift) && !isDashing)
        {
            StartCoroutine(Dash());
        }
    }

    private IEnumerator Dash()
    {
        isDashing = true;
        yield return new WaitForSeconds(dashDuration);
        isDashing = false;
    }
}

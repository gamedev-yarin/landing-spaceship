using UnityEngine;

/**
 * This component moves its object with Force
 */
public class Mover: MonoBehaviour {
    [Tooltip("Movement vector in meters per second")]
    [SerializeField] Vector3 force;
    [SerializeField] ForceMode forceMode = ForceMode.Force;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    private void FixedUpdate() {
        rb.AddForce(force, forceMode);
    }

    public void SetForce(Vector3 newforce, ForceMode newforceMode) {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(newforce, newforceMode);
    }
}

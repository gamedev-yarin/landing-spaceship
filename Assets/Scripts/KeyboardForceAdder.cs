using UnityEngine;


/**
 *  This component allows the player to add force to its object using the arrow keys.
 *  Works with a 3D RigidBody.
 */
[RequireComponent(typeof(Rigidbody))]
public class KeyboardForceAdder : MonoBehaviour {
    [Tooltip("The move force that the player's feet use for walking, in newtons.")]
    [SerializeField] float moveForce = 5f;
    [SerializeField] ForceMode forceMode = ForceMode.Force;


    private Rigidbody rb;


    void Start() {
        rb = GetComponent<Rigidbody>();
    }


    /*
     * Note that updates related to the physics engine should be done in FixedUpdate and not in Update!
     */
    private void FixedUpdate() {
        float horizontal = Input.GetAxis("Horizontal"); // +1 if right arrow is pushed, -1 if left arrow is pushed, 0 otherwise
        float vertical = Input.GetAxis("Vertical");     // +1 if up arrow is pushed, -1 if down arrow is pushed, 0 otherwise
        Vector3 force = new Vector3(horizontal, vertical, 0) * moveForce;
        rb.AddForce(force, forceMode);
    }
}

using System.Collections;
using UnityEngine;


/**
 * This component triggers an explosion effect and destroys its object 
 * whenever its object collides with something in a velocity above the threshold.
 */
[RequireComponent(typeof(Rigidbody))]
public class CollisionExploder: MonoBehaviour {
    [SerializeField] float minImpulseForExplosion = 1.0f;
    [SerializeField] GameObject explosionEffect = null;
    [SerializeField] float explosionEffectTime = 0.68f;

    private Rigidbody rb;
    private Vector3 startLevelPos;
    void Start() {
        rb = GetComponent<Rigidbody>();
        startLevelPos = transform.position;
    }

    private void OnCollisionEnter(Collision collision) {
        // In 3D, the Collision object contains an .impulse field.
        // In 2D, the Collision2D object does not contain it - so we have to compute it.
        float impulse = collision.relativeVelocity.magnitude;
        Debug.Log(gameObject.name + " collides with " + collision.collider.name
            + " at velocity " + collision.relativeVelocity + " [m/s], impulse "+ impulse+" [kg*m/s]");
        if (impulse > minImpulseForExplosion) {
            StartCoroutine(Explosion());
        }
    }

    IEnumerator Explosion() {
        explosionEffect.SetActive(true);
        yield return new WaitForSeconds(explosionEffectTime);
        explosionEffect.SetActive(false);
        transform.position = startLevelPos;
    }
}

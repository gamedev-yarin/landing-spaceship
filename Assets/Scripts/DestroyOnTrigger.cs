using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys object whenever it triggers a collider with the given tag.
 */
public class DestroyOnTrigger : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    private void OnTriggerEnter(Collider collision) {
        if (collision.tag == triggeringTag) {
            Destroy(collision.gameObject);
        }
    }
}

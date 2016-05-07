using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour {

    void OnTriggerExit(Collider other)
    {
        // Destroy everything that leaves the trigger
		if (other.name != "Player") {
			Destroy (other.gameObject);
		}
    }
}
 
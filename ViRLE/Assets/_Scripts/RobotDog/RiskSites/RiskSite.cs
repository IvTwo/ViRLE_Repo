using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiskSite : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if (other.TryGetComponent(out DogController robotDog)) {

        }
    }
}

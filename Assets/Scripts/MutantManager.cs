using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutantManager : MonoBehaviour
{
    public GameObject prefabMutant;
    int mutantCount;

    private void Update() {
        if (Input.GetKey(KeyCode.Space)) {
            mutantCount++;
            GameObject clone = Instantiate(prefabMutant);
            clone.name = "Mutant_" + mutantCount;
        }
    }
}

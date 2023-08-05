using System.Collections.Generic;
using UnityEngine;

public class MutantManager : MonoBehaviour {
    public GameObject prefabMutant;
    public float spawnCooldown;
    public Transform poolContent;
    public List<GameObject> poolMutantPrefab;

    int mutantCount;
    float countdown;

    private void Start() {
        countdown = spawnCooldown;
        poolMutantPrefab = new List<GameObject>();
        for (int i = 0; i < poolContent.childCount; i++) {
            GameObject temp = poolContent.GetChild(i).gameObject;
            temp.SetActive(false);
            poolMutantPrefab.Add(temp);
        }
    }

    private GameObject GetPrebaf() {
        mutantCount = 0;
        foreach (GameObject temp in poolMutantPrefab) {
            mutantCount++;
            if (!temp.activeSelf) {
                temp.transform.position = Vector3.zero;
                temp.SetActive(true);
                temp.GetComponent<Animator>().SetBool("IsWalking", true);
                return temp;
            }
            if (mutantCount >= poolMutantPrefab.Count - 1) {
                throw new UnityException("No more objects in pool");
            }
        }
        return null;
    }

    private void Update() {
        countdown -= Time.deltaTime;
        if (countdown <= 0) {
            GetPrebaf();
            countdown = spawnCooldown;
        }
    }
}
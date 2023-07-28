using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MutantMovement : MonoBehaviour
{
    [SerializeField] List<Transform> target = new List<Transform>();

    private NavMeshAgent agent;
    private Animator anim;
    private int itPositions;

    // Start is called before the first frame update
    void Start()
    {
        GameObject contentTarget = GameObject.Find("ContentTarget");
        for(int i = 0; i < contentTarget.transform.childCount; i++) {
            target.Add(contentTarget.transform.GetChild(i).transform);
        }
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        ShuffleArray.Shuffle(target);
        itPositions = 0;
        anim.SetBool("IsWalking", true);
    }

    // Update is called once per frame
    void Update() {
        Move();
    }

    private void Move() {
        agent.SetDestination(target[itPositions].position);
        if (Vector3.Distance(target[itPositions].position, transform.position) < 2) {
            itPositions++;
            if(itPositions >= target.Count - 1) {
                itPositions = 0;
                ShuffleArray.Shuffle(target);
            }
        }
    }
}

public static class ShuffleArray {
    public static void Shuffle<T>(this IList<T> ts) {
        var count = ts.Count;
        var last = count - 1;
        for (var i = 0; i < last; ++i) {
            var r = UnityEngine.Random.Range(i, count);
            var tmp = ts[i];
            ts[i] = ts[r];
            ts[r] = tmp;
        }
    }
}
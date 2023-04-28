using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class PositionAnimation : MonoBehaviour
{
    public Vector3[] targets;
    public float speed = 1.0f;

    IEnumerator Start()
    {
        int index = 0;

        while (true)
        {
            Vector3 target = targets[index];
            float journeyLength = Vector3.Distance(transform.position, target);
            float startTime = Time.time;

            while (transform.position != target)
            {
                float distCovered = (Time.time - startTime) * speed;
                float fracJourney = distCovered / journeyLength;
                transform.position = Vector3.Lerp(transform.position, target, fracJourney);

                yield return null;
            }

            index = (index + 1) % targets.Length;

            yield return new WaitForSeconds(0.01f);
        }
    }
}

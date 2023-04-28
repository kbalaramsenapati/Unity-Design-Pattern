using CommandPatterns.Calculator;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float moveSpeed = 0.05f;
    public int killPositionX = -10;
    Transform selfTransform;
    public Vector3 OriginalPosition;
    public float startTimming;
    public bool ismove;
    // Start is called before the first frame update
    void Start()
    {
        selfTransform = transform;
        OriginalPosition = transform.localPosition;
        StartCoroutine(waitforPipeMove());
    }

    // Update is called once per frame
    void Update()
    {
        if (ismove)
        {
            //if (!GameManager.Instance.gameOver)
            selfTransform.localPosition -= new Vector3(moveSpeed, 0);
            if (selfTransform.localPosition.x < killPositionX)
            {
                selfTransform.localPosition = OriginalPosition;
                //this.gameObject.SetActive(false);
                //Destroy(gameObject);
            }
        }
    }
    IEnumerator waitforPipeMove()
    {
        yield return new WaitForSeconds(startTimming);
        ismove = true;
    }
}

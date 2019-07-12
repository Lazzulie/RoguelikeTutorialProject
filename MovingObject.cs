using UnityEngine;
using System.Collections;



public abstract class MovingObject : MonoBehaviour
{
    
    public float moveTime = 0.1f;
    public LayerMask blockingLayer;


    private BoxCollider2D boxCollider;
    private Rigidbody2D rb2D;
    private float inverseMoveTime;


    // Start is called before the first frame update
    protected virtual void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        rb2D = GetComponent<Rigidbody2D>();
        inverseMoveTime = 1f / moveTime;
    }

    protected IEnumerator SmoothMovement(Vector3 end)
    {
        float sqrReaminingDistance = (transform.position - end).sqrMagnitude;

        while(sqrReaminingDistance > float.Epsilon)
        {
            Vector3 newPos = Vector3.MoveTowards(rb2D.position, end, inverseMoveTime * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

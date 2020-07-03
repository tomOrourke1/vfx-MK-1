using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Follow : MonoBehaviour
{
    [SerializeField]
    private VisualEffect visualEffect;


    public GameObject target;

    public float strength;

    public float distance;



    public bool left;
    public bool closed;


    private void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        target.transform.position = ray.GetPoint(distance);

    }

    private void LateUpdate()
    {
        
        if(left)
        {
            if(!closed && Input.GetMouseButtonDown(0))
            {
                visualEffect.Stop();
                closed = !closed;
            }
            else if (closed && Input.GetMouseButtonDown(0))
            {
                visualEffect.Play();
                closed = !closed;
            }
        }
        else
        {
            if (!closed && Input.GetMouseButtonDown(1))
            {
                visualEffect.Stop();

                closed = !closed;
            }
            else if (closed && Input.GetMouseButtonDown(1))
            {
                visualEffect.Play();

                closed = !closed;
            }
        }


        var pos = target.transform.position - transform.position;

        visualEffect.SetFloat("strength", strength);
        visualEffect.SetVector3("target", pos);


    }



}

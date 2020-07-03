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


    private void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        target.transform.position = ray.GetPoint(distance);

    }

    private void LateUpdate()
    {

        var pos = target.transform.position - transform.position;

        visualEffect.SetFloat("strength", strength);
        visualEffect.SetVector3("target", pos);
        
    }



}

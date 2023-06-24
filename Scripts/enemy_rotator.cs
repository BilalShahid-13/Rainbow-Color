using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class enemy_rotator : MonoBehaviour
{
    [SerializeField] float force1,force2;
    [SerializeField] movement movement;
    GameObject[] enimes;
    int i,j;

    private void Awake()
    {
        movement.enabled = true;
    }

    private void Start()
    {
         enimes = GameObject.FindGameObjectsWithTag("enemy");

         i = enimes.Length;

    }
    private void FixedUpdate()
    {
        rotate();
    }

    public void rotate()
    {
        j = enimes.Length / 2;

        for (int i = 0; i < j; i++)
        {
            enimes[i].GetComponent<Transform>().Rotate(0f, 0f, force1 * Time.fixedDeltaTime);
        }

        for (int z = enimes.Length-1; z >= j; z--)
        {
            enimes[z].GetComponent<Transform>().Rotate(0f, 0f, force2 * Time.fixedDeltaTime);
        }


    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}

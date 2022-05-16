using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Stop : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponentInParent<Move>().isMove = false;
            other.gameObject.GetComponentInParent<Move>().rb.velocity= Vector3.zero;
            this.gameObject.SetActive(false);
        }
    }
}

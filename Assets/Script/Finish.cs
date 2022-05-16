using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<LevelManager>().levelPanel.SetActive(true);
            GameObject.Find("Player").GetComponent<Move>().isMove = false;
           GameObject.Find("Player"). GetComponent<Rigidbody>().velocity = Vector3.zero;
            
           
        }

    }
}

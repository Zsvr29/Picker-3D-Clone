using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bitis : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
   
        if (other.CompareTag("Player"))
        {
            GameObject.Find("Player").GetComponent<Move>().isMove = false;
           GameObject.Find("Player"). GetComponent<Rigidbody>().velocity = Vector3.zero;
            StartCoroutine(CoroutineFinish());
        }
    }
     IEnumerator CoroutineFinish()
    {
        yield return new WaitForSeconds(1f);
        FindObjectOfType<SaveSystem>().LoadLevel();
        GameObject.Find("Player").GetComponent<Move>().isMove = true;
    }
}

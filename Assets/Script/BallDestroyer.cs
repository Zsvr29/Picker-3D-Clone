using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
public class BallDestroyer : MonoBehaviour
{
    public TextMeshProUGUI text;
    int sayac;
    public int hedef;
    public  GameObject sagKapi, solKapi;
    int puan;
    public Color color;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Top")
        {
            sayac++;
            text.text = sayac.ToString() + " / "+hedef;
            Debug.Log(sayac);
            other.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            Destroy(other.gameObject, 0.5f);
            if (sayac >= hedef)
            {
                StartCoroutine(CoroutineSay());
                gameObject.GetComponent<MeshRenderer>().material.color = color;
            }
        }
    }
      IEnumerator CoroutineSay()
    {
        yield return new WaitForSeconds(1f);
        transform.DOMoveY(-0.97f, 1.3f);
        sagKapi.transform.DORotate(new Vector3(0, 0, -75),0.7f);
        solKapi.transform.DORotate(new Vector3(0, 0, 75),0.7f);
        sagKapi.GetComponent<Confeti>().particle.Play();
        yield return new WaitForSeconds(1f);
        GameObject.Find("Player").GetComponent<Move>().isMove = true;
    } 
}

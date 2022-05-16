using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AnimateCube : MonoBehaviour
{
    public List<GameObject> gameObjects = new List<GameObject>();
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "KüpTop")
        {
            other.gameObject.SetActive(false);
            for (int i = 0; i < gameObjects.Count; i++)
            {
                gameObjects[i].SetActive(true);
            }
        }
    }
}

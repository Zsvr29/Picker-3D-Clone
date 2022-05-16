using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject levelPanel;
   public void levelLoad()
    {
        levelPanel.SetActive(false);
        StartCoroutine(CoroutineFinish());
    }
    IEnumerator CoroutineFinish()
    {
        yield return new WaitForSeconds(1f);
        FindObjectOfType<SaveSystem>().LoadLevel();
        yield return new WaitForSeconds(1f);
        GameObject.Find("Player").GetComponent<Move>().isMove = true;
    }
}

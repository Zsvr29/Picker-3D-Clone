using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class SaveSystem : MonoBehaviour
{
    public GameObject[] levelArray;
    public GameObject player;
    public int levelIndex;
    public bool isDelete = false;
    public void Start()
    {
        if (isDelete==true)
        {
           PlayerPrefs.DeleteAll();
        }
        SaveLevel();
    }
    public void SaveLevel()
    {
        int level = PlayerPrefs.GetInt("levelIndex");
        Debug.Log(level);
        for (int i = 1; i <= level; i++)
        {
            if (level !=0)
            {
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z + 173);
            }
        } 
    }
    public void LoadLevel()
    {
        levelIndex = PlayerPrefs.GetInt("levelIndex");
        player.transform.DOMoveZ(player.transform.position.z + 47, 1f);
        if (levelIndex >=levelArray.Length)
        {
            levelIndex = levelArray.Length - 1;
        }
        levelIndex++;
        PlayerPrefs.SetInt("levelIndex", levelIndex);
        Debug.Log(PlayerPrefs.GetInt("levelIndex"));
    }
}

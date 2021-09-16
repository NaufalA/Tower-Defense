using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private LevelManager _instance = null;

    public LevelManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<LevelManager>();
            }

            return _instance;
        }
    }

    [SerializeField] private Transform towerUIParent;
    [SerializeField] private GameObject towerUIPrefab;
    
    [SerializeField] private Tower[] towerPrefabs;
    private void Start()
    {
        InstantiateAllTowerUI();
    }

    private void InstantiateAllTowerUI()
    {
        foreach (var tower in towerPrefabs)
        {
            GameObject newTowerUIObj = Instantiate(towerUIPrefab.gameObject, towerUIParent);
            TowerUI newTowerUI = newTowerUIObj.gameObject.GetComponent<TowerUI>();

            newTowerUI.SetTowerPrefab(tower);
            newTowerUI.transform.name = tower.name;
        }
    }
}

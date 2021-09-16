using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] private SpriteRenderer towerPlace;
    [SerializeField] private SpriteRenderer towerHead;

    [SerializeField] private int shootPower = 1;
    [SerializeField] private float shootDistance = 1f;
    [SerializeField] private float shootDelay = 5f;
    [SerializeField] private float bulletSpeed = 1f;
    [SerializeField] private float bulletSpreadRadius = 0f;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public Sprite GetTowerHeadIcon()
    {
        return towerHead.sprite;
    }
}

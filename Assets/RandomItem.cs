using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomItem : MonoBehaviour
{
    [SerializeField] private GameObject[] items;
    [SerializeField] private float minXDis;
    [SerializeField] private float maxXDis;
    [SerializeField] private float minYDis;
    [SerializeField] private float maxYDis;
    [SerializeField] private PlayerController player;
    [SerializeField] private int times;
    // Start is called before the first frame update
    void Start()
    {
        Generate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Generate()
    {
       
        for (int i = 0; i <= times; i++)
        {
            var distanceX = Random.Range( minXDis,  maxXDis );
            var distanceY = Random.Range( minYDis, maxYDis );
            var position = new Vector3(player.transform.position.x + distanceX, player.transform.position.y + distanceY, 0);
            // hoac tru, cho zo array position

            GameObject gameObject = Instantiate(items[Random.Range(0, items.Length)], position, Quaternion.identity);
        }


    }
}

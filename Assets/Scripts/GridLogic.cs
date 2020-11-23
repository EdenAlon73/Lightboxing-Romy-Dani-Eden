using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridLogic : MonoBehaviour
{
   // [SerializeField] private GameObject[] gridOfLights;
    
    
    [SerializeField] private Transform lightBulb;
    [SerializeField] private int maxY;
    [SerializeField] private int maxX;
    [SerializeField] private float offsetX;
    [SerializeField] private float offsetY;
    [SerializeField] private float offsetZ;
    
    // Material settings
    Material bulbColor;
    
    // lists of active ana notActive objects
    public List<GameObject> activeCubesList = new List<GameObject>();
    public List<GameObject> notActiveCubesList = new List<GameObject>();
    public List<GameObject> allCubesList = new List<GameObject>();



    private void Start()
    {
        for (int y = 0; y < maxY; y++)
        {
            for (int x = 0; x < maxX; x++)
            {
                var prefab = Instantiate(lightBulb, new Vector3(offsetX, offsetY, offsetZ), Quaternion.identity);
                prefab.transform.localPosition = new Vector3(x * 1f, 0, y * 1f);
                
                //Fetch the Material from the Renderer of the GameObject
                bulbColor = prefab.GetComponent<Renderer>().material;
        
        
                //add object to the list
                notActiveCubesList.Add(prefab.gameObject);
                allCubesList.Add(prefab.gameObject);
            }
        }
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{

    [SerializeField] private GameObject Map;
    bool init = false;
    void Start()
    {
   
    }

    void Update()
    {if (init) return;
        MapGenerating();
        init = true;
        
    }

    private void MapGenerating()
    {
        if (GameMapList.Instance.GameMap == null) return;
        int lenght = GameMapList.Instance.GameMap.Count;
        for ( int i =0; i<lenght; i++)
        {
           
            Instantiate(GameMapList.Instance.GameMap[i].GameObject, new Vector3(0, i, 0), Quaternion.identity);
          
        }
         
        }
}

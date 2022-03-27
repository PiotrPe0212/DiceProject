using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{

    [SerializeField]
    private MapTilesBase TileMapBase;
    private int GeneratingQuant = 10;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MapGenerating()
    {
        int lenght = TileMapBase.LenghtGen();
        int random;
        for ( int i =0; i<GeneratingQuant; i++)
        {
            random = Helpers.RandomNumberInt(0, lenght );
          
        }
         
        }
}

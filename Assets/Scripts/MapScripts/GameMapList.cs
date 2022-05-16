using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMapList : MonoBehaviour
{
    public static GameMapList Instance;
    [SerializeField] private int GeneratingQuant = 10;
    [SerializeField] private MapTilesBase TileMapBase;
    private List<MapTile> _gameMap;

    public IReadOnlyList<MapTile> GameMap => _gameMap;

    private void Awake()
    {
        Instance = this;
        
    }
    void Start()
    {
        GameMapListGenerating();
    }
    void Update()
    {
        
    }

    private void GameMapListGenerating()
    {
        _gameMap = new List<MapTile>();
        int lenght = TileMapBase.LenghtGen();
        int random;
        for (int i = 0; i < GeneratingQuant; i++)
        {
            random = Helpers.RandomNumberInt(0, lenght);

           _gameMap.Add(TileMapBase.MapTiles[random]);

        }
    }

}

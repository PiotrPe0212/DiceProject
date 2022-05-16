using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(MapTilesBase), menuName = "Game/MapTilesBase")]


// List of existing types of map tiles (tile= type+GO)
public class MapTilesBase : ScriptableObject
{
    [SerializeField] private MapTile[] _mapTiles;

        public IReadOnlyList<MapTile> MapTiles => _mapTiles;
   
    public int LenghtGen()
    {
        return _mapTiles.Length;
    }
}

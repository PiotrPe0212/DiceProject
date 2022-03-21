using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(MapItem), menuName = "Game/MapTilesBase")]

public class MapTilesBase : ScriptableObject
{
    [SerializeField] private List<MapTile> _mapTiles;

        public IReadOnlyList<MapTile> MapTiles => _mapTiles;
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(MapItem), menuName = "Game/MapTile")]

// Indyvidual map tile with type and GO
public class MapTile : ScriptableObject
{
    [SerializeField] private MapItem.MapType mapItem;
    [SerializeField] private GameObject gameObject;

    public  MapItem.MapType MapItems => mapItem;
    public GameObject GameObject => gameObject;
}

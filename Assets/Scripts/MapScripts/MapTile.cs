using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(MapItem), menuName = "Game/MapTile")]
public class MapTile : ScriptableObject
{
    [SerializeField] private MapItem.MapItems mapItem;
    [SerializeField] private GameObject gameObject;

    public  MapItem.MapItems MapItems => mapItem;
    public GameObject GameObject => gameObject;
}

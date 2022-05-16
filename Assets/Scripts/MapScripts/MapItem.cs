using System.Collections;
using UnityEngine;


    [CreateAssetMenu(fileName = nameof(MapItem), menuName = "Game/MapItem")]

    // Enum with types of map tiles
    public class MapItem : ScriptableObject
    {
        public enum MapType
        {
            Fight,
            Something1,
            Something2
        }
        
    }

using System.Collections;
using UnityEngine;


    [CreateAssetMenu(fileName = nameof(MapItem), menuName = "Game/MapItem")]
    public class MapItem : ScriptableObject
    {
        public enum MapItems
        {
            Fight,
            Something1,
            Something2
        }
        
    }

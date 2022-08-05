using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SG
{

    [CreateAssetMenu(menuName = "Items / Weapon Item")]
    public class WeaponItem : Item
    {
        public GameObject modelPrefab;
        public bool isUnarmed;
    }
}
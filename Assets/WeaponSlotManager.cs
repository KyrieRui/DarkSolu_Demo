using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SG
{
    public class WeaponSlotManager : MonoBehaviour
    {
        WeaponHolderSlot leftHandSlot;
        WeaponHolderSlot rightHandSlot;

        private void Awake()
        {
            WeaponHolderSlot[] weaponHolderSlots = GetComponentsInChildren<WeaponHolderSlot>();
            foreach (WeaponHolderSlot weaponSlots in weaponHolderSlots)
            {
                if(weaponSlots.isLeftHandSlot)
                {
                    leftHandSlot = weaponSlots;
                }
                else if (weaponSlots.isRightHandSlot)
                {
                    rightHandSlot = weaponSlots;
                }
            }
        }

        public void LoadWeaponOnSlot(WeaponItem weaponItem,  bool isLeft)
        {
            if(isLeft)
            {
                leftHandSlot.LoadWeaponModel(weaponItem);
            }
            else
            {
                rightHandSlot.LoadWeaponModel(weaponItem);
            }
        }
    }
}
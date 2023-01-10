using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCrafting : MonoBehaviour
{
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private LayerMask interactLayerMask;
   private void Update()
   {
    if(Input.GetKeyDown(KeyCode.E)||Input.GetMouseButtonDown(0)){
        float interactDistance=3f;
        if(Physics.Raycast(playerCameraTransform.position,playerCameraTransform.forward, out RaycastHit raycastHit,interactDistance)){
            if(raycastHit.transform.TryGetComponent(out CraftingAnvil craftingAnvil)){
                if(Input.GetKeyDown(KeyCode.E)){
                   // craftingAnvil.NextRecipe();
                }
                if(Input.GetMouseButtonDown(0)){
                  //  craftingAnvil.Craft();
                }
            }
        }
    }
   }
}

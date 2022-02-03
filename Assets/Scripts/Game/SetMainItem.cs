
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMainItem : MonoBehaviour
{
  [SerializeField] private Item[] items;

  private void Start()
  {
    items = new Item[transform.childCount];
    items = GetComponentsInChildren<Item>();
   
    DeactivateAllItem();
  }

  public void ActivateRandomItem()
  {
    items[Random.Range(0,items.Length)].gameObject.SetActive(true);
  }

  public void DeactivateAllItem()
  {
    foreach (Item obj in items)
      obj.gameObject.SetActive(false);
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Snowman : MonoBehaviour
{
     [SerializeField] private List<Renderer> _allBodyParts = new List<Renderer>();
     [SerializeField] private List<GameObject> _allCaps = new List<GameObject>();
     [SerializeField] private Text _nickname;
     

     public void SetMaterial(Material material)
     {
          foreach (var part in _allBodyParts)
          {
               part.material = material;
          }
     }

     public void SetHats(int index)
     {
          for (int i = 0; i < _allCaps.Count; i++)
          {
               if (i == index)
               {
                    _allCaps[i].SetActive(true);
               }
               else
               {
                    _allCaps[i].SetActive(false);
               }
          }
     }

     public void SetNickName(string value)
     {
          _nickname.text = value;
     }
}

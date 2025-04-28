using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class Tab_Manager : MonoBehaviour
{
    [SerializeField]
    public List<Tab_General> ListTab;
   

    protected void Reset()
    {
        LoadList();
    }
    
    public void LoadList()
    {
        if (ListTab.Count >0) return;
        foreach (Transform child in this.transform) {
            if (child.GetComponent<Tab_General>())
            {
                Tab_General tab = child.gameObject.GetComponent<Tab_General>();
                ListTab.Add(tab);
            }
            
        }
        
    }
    
    
    
}

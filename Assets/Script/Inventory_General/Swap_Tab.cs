using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Tab_Manager))]
public class Swap_Tab :MonoBehaviour
{
    public Tab_Manager Tab_Manager;
    public Tab_General current_tab;
    public void Start()
    {
        Get_Current_Tab();
    }
    public void Get_Current_Tab()
    {
        if (current_tab != null) return;
        foreach(Tab_General tab_General in Tab_Manager.ListTab)
        {
            if (current_tab != null) 
            {
                tab_General.UI_Control.gameObject.SetActive(false);
                tab_General.UI_Control.Status = false;
            }
            if (tab_General.UI_Control.gameObject.activeSelf)
            {
                current_tab = tab_General;
            }
            
            
        }
    }

    public void Swap_Tab_Action(Tab_General newtab)
    {
        Debug.Log("tap swap");
        if (newtab == null) return ;
        if (newtab.UI_Control.gameObject.activeSelf) return ;
        SwapScreenTab(newtab);


    }
    private void SwapScreenTab(Tab_General newtab)
    {
        current_tab.UI_Control.gameObject.SetActive(false);
        current_tab.UI_Control.Set_Status();
        newtab.UI_Control.gameObject.SetActive(true);
        newtab.UI_Control.Set_Status();
        current_tab = newtab;
    }
}

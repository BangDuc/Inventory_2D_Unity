using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor.Events;
#endif



[RequireComponent(typeof(Button))] 
public class Tab_General : MonoBehaviour, ITab
{
    [SerializeField]
    public UI_General UI_Control;
    public Swap_Tab Swap_Tab;
    public Button _Button;

    private void Reset()
    {
        GetSwap_Tab();
        GetButton();
        Set_Button();
        
    }
    public void Set_Button()
    {
        #if UNITY_EDITOR
        UnityEventTools.AddPersistentListener(_Button.onClick, Swap_tab);
        #endif

        //_Button.onClick.AddListener(Swap_tab); for RuntimeMode using with Start
    }
    public void GetButton()
    {
        if (_Button != null) return;
        _Button = this.GetComponent<Button>();
    }
    public void GetSwap_Tab()
    {
        if (Swap_Tab != null) return;
        Swap_Tab=GetComponentInParent<Swap_Tab>();
    }
   
    public void Swap_tab()
    {
        if (this.UI_Control.gameObject.activeSelf)
        {
            Swap_Tab.current_tab = this;
        }
        Swap_Tab.Swap_Tab_Action(this);
    }

}

using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Button))] 
public class Button_Tab_General : MonoBehaviour, ITab
{
    [SerializeField]
    public UI_General UI_Control;
    public Swap_Tab Swap_Tab;
    public Button _Button;

    private void Start()
    {
        GetButton();
        Set_Button();
    }
    public void Set_Button()
    {
        //_Button.onClick.AddListener(Swap_tab);
    }
    public void GetButton()
    {
        if (_Button != null) return;
        _Button = this.GetComponent<Button>();
    }
   
    //public void Swap_tab()
    //{
    //    if (this.UI_Control.gameObject.activeSelf)
    //    {
    //        Swap_Tab.current_tab = this;
    //    }
    //    Swap_Tab.Swap_Tab_Action(this);
    //}

}

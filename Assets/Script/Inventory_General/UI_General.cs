using Unity.VisualScripting;
using UnityEngine;

public class UI_General: MonoBehaviour 
{
    [SerializeField]
    public bool Status;
    public void Set_Status()
    {
        Status = this.gameObject.activeSelf;
    }
    public virtual void Start()
    {
        Set_Status();
    }
}
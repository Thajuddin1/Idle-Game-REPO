using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    public TMP_Text flaskText;
    public Data data;

    public void Start()
    {
        data = new Data();
        data.flasks = 1;
    }
    public void Update()
    {
        flaskText.text = data.flasks + "Flasks";
       
    }
    public void generateflasks()
    {
        data.flasks += 1;
    }

}

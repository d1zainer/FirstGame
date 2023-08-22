using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum DeformationType {wight, high }

public class GateApp : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] Image _imageglass;
    [SerializeField] Image _imagetop;
    [SerializeField] Color _colorPozitiv;
    [SerializeField] Color _colorNegativ;

    [SerializeField] DeformationType _deformationType;
    [SerializeField] GameObject _downlabel;
    [SerializeField] GameObject _uplabel;
    [SerializeField] GameObject _shirinkLabel;
    [SerializeField] GameObject _expendLabel;

    public void UpdateVision(DeformationType _deformationType, int value)
    {

        string prefix = "";    
        if (value > 0)
        {
            prefix = "+";
            SetColor(_colorPozitiv);
        }
        else if(value == 0)
        {
            SetColor(Color.grey);
        }
        else
        
        {
            
            SetColor(_colorNegativ);
        }
        _text.text = prefix+ value.ToString();


        _downlabel.SetActive(false);
        _uplabel.SetActive(false);
        _shirinkLabel.SetActive(false);
        _expendLabel.SetActive(false);



        if (_deformationType == DeformationType.wight)
        {
            if (value > 0) 
            {
                _expendLabel.SetActive(true);
            }
            else
            {
                _shirinkLabel.SetActive(true);
            }

        }
        else if (_deformationType == DeformationType.high)  
        {
            if (value > 0) 
            {
                _uplabel.SetActive(true);
            }
            else
            {
                _downlabel.SetActive(true);
            }
        }
    }
    void SetColor(Color color)
    {
        _imagetop.color = color;
        _imageglass.color = new Color(color.r, color.g, color.b, 0.5f);
    }

}

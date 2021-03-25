using UnityEngine;
using UnityEngine.UI;

public class CarSelection : MonoBehaviour
{
    [SerializeField] private Button previousButton;
    [SerializeField] private Button nextButton;
    private int currentCar;

    private void Start()
    {
        currentCar = SaveManager.instance.currentCar;
        SelectCar(currentCar);
    }

    private void SelectCar(int _index)
    {
        for (int i = 0; i < transform.childCount; i++)
            transform.GetChild(i).gameObject.SetActive(i == _index);
    }

    public void ChangeCar(int _change)
    {
        currentCar += _change;

        if (currentCar > transform.childCount - 1)
            currentCar = 0;
        else if (currentCar < 0)
            currentCar = transform.childCount - 1;

        SaveManager.instance.currentCar = currentCar;
        SaveManager.instance.Save();
        SelectCar(currentCar);
    }
}
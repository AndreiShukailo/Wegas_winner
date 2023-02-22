using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    [SerializeField] private WinningView _winningView;
    [SerializeField] private StockView _stockView;
    [SerializeField] private AnimationController _animationController;

    [Range(1, 45f)] [SerializeField] private float _rotaionStep;
    [SerializeField] private float _speed;

    [SerializeField] private List<Prize> _prizes;


    private int _minNumberOfRotations = 200;
    private int _maxNumbersOfRotations = 500;

    private bool _allowSpin;
    private Vector3 _rotation;

    private void Start()
    {
        _allowSpin = true;
        _rotation = new Vector3(0, 0, _rotaionStep);
    }

    private IEnumerator SpinWheel()
    {
        _allowSpin = false;

        int numberOfRotation = Random.Range(_minNumberOfRotations, _maxNumbersOfRotations);
        float deley = 0;

        for (int i = 0; i < numberOfRotation; i++)
        {
            transform.Rotate(_rotation);

            deley = 1 / _speed *  1 / (float)(numberOfRotation - i); 

            yield return new WaitForSeconds(deley);
        }

        var angle = (float)System.Math.Round(transform.rotation.eulerAngles.z);

        foreach (var item in _prizes)
        {
            if (item.IsWin(angle))
            {
                item.AddPrize(_prizes);
                _animationController.WiningAnimation?.Invoke(item is Coin);
                _winningView.UpdateView(item);
                _stockView.UpdateCoinsInView();
                break;
            }
        }

        _allowSpin = true;
    }

    public void OnSpinButtonClick()
    {
        if (_allowSpin)
            StartCoroutine(SpinWheel());
    }
}

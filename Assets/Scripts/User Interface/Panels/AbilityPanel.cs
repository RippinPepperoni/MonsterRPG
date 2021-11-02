#pragma warning disable 0649
using UnityEngine;
using UnityEngine.UI;

namespace MonsterRPG
{
    public class AbilityPanel : Panel
    {
        [SerializeField]
        private Text textComponent;

        [SerializeField]
        private SliderView[] sliderViews;

        private Attribute _cost;
        private Attribute _cooldown;

        public void Bind(AbilitySpec spec)
        {
            textComponent.text = spec.Asset.Name;

            _cost = spec.Cost;
            _cooldown = spec.Cooldown;

            SetNumberOfSliderViews();
        }

        public override void Show()
        {
            base.Show();

            if (_cost != null && _cooldown != null)
            {
                _cost.onAttributeChanged += Refresh;
                _cooldown.onAttributeChanged += Refresh;
            }
        }

        private void SetNumberOfSliderViews()
        {
            for (int i = 0; i < sliderViews.Length; i++)
            {
                var view = sliderViews[i];

                if (_cost.MaxValue > i)
                {
                    view.gameObject.SetActive(true);
                    view.Refresh(1f);
                }
                else
                {
                    view.Refresh(0f);
                    view.gameObject.SetActive(false);
                }
            }
        }

        private void Refresh()
        {
            int count = Mathf.RoundToInt(_cost.MaxValue - 1);
            int value = Mathf.RoundToInt(_cost.Value);

            for (int i = count; i >= 0; i--)
            {
                if (value == i)
                {
                    float normalisedValue = _cooldown.Value / _cooldown.MaxValue;
                    sliderViews[i].Refresh(normalisedValue, false);
                }
                else if (value > i)
                {
                    sliderViews[i].Refresh(1f);
                }
                else
                {
                    sliderViews[i].Refresh(0f);
                }
            }
        }

        public override void Hide()
        {
            base.Hide();

            if (_cost != null && _cooldown != null)
            {
                _cost.onAttributeChanged -= Refresh;
                _cooldown.onAttributeChanged -= Refresh;
            }
        }
    }
}

/*
 
            private void SetSliderCount()
        {
            for (int i = 0; i < sliders.Length; i++)
            {
                if (_cost.MaxValue > i)
                {
                    sliders[i].gameObject.SetActive(true);
                }
                else
                {
                    sliders[i].gameObject.SetActive(false);
                }
            }
        }

        private void Refresh()
        {
            for (int i = 0; i < _cost.MaxValue; i++)
            {
                if (_cost.Value > i)
                {
                    sliders[i].value = 1;
                }
                else
                {
                    sliders[i].value = 0;
                }
            }
        }
    
 */

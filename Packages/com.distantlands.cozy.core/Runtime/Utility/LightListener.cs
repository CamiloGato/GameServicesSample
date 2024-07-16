using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DistantLands.Cozy
{

    public class LightListener : MonoBehaviour
    {

        public Material onMat;
        public Material offMat;
        private Light _light;
        private Renderer _render;

        public void TurnOnLight()
        {

            if (_light == null)
                _light = GetComponent<Light>();
            if (_render == null)
                _render = GetComponent<Renderer>();

            _render.material = onMat;
            _light.enabled = true;

        }

        public void TurnOffLight()
        {

            if (_light == null)
                _light = GetComponent<Light>();
            if (_render == null)
                _render = GetComponent<Renderer>();

            _render.material = offMat;
            _light.enabled = false;
        }
    }
}
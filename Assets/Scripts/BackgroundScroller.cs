using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class BackgroundScroller : MonoBehaviour
    {
        [Range(-10f, 10f)]
        public float scrollSpeed = 10f;
        private float offset;
        private Material mat;


        private float speed = 10.0f;
        private float forwardInput;


        // Start is called before the first frame update
        void Start()
        {
            mat = GetComponent<Renderer>().material;
        }

        // Update is called once per frame
        void Update()
        {
            forwardInput = Input.GetAxis("Horizontal");
            offset += (Time.deltaTime * scrollSpeed);

            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.RightArrow))
            {
                offset += (2 * forwardInput);
            }

            mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        }
    }


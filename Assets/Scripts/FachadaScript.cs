using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;
public class FachadaScript : baseScript1
{
    // Start is called before the first frame update
    public RawImage Banner1;
    public RawImage Banner2;
    public RawImage Banner3;
    public RawImage Logo;

    void Start()
    {
        
    }
 void ImagenDb(string url){

         StartCoroutine(JsonRequest(url, (UnityWebRequest req) => {
              var json_text = req.downloadHandler.text;
              Fachada fachada = JsonUtility.FromJson<Fachada>(json_text);                     

                cargarImagen(fachada.BannerVert1, this.Banner1 );
                cargarImagen(fachada.BannerVert2, this.Banner2 );
                cargarImagen(fachada.BannerVert3, this.Banner3 );
                cargarImagen(fachada.BannerHoriz1, this.Logo );
               

        }));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[System.Serializable]
    public class Fachada
    {
        public string BannerVert1;
        public string BannerVert2;
        public string BannerVert3;
        public string BannerHoriz1;

    }

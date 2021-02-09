using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;
public class PabellonScript : baseScript1
{
    
    void Start()
    {
       
    }

    public RawImage PublicidadVert1;
    public RawImage PublicidadVert2;
    public RawImage PublicidadHori1;
    public RawImage PublicidadHori2;
    public RawImage BannerExpoHorz;


    // Update is called once per frame
    void Update()
    {
        
    }
     public void FocusCanvas (string p_focus) {
    #if !UNITY_EDITOR && UNITY_WEBGL
    if (p_focus == "0") {
        WebGLInput.captureAllKeyboardInput = false;
    } else {
        WebGLInput.captureAllKeyboardInput = true;
    }
    #endif
    }
 
    void ImagenDb(string url){

         StartCoroutine(JsonRequest(url, (UnityWebRequest req) => {
              var json_text = req.downloadHandler.text;
              Pabellon pabellon = JsonUtility.FromJson<Pabellon>(json_text);                     
              cargarImagen(pabellon.PublicidadVert1, this.PublicidadVert1 );
              cargarImagen(pabellon.PublicidadVert2, this.PublicidadVert2 );
              cargarImagen(pabellon.PublicidadHori1, this.PublicidadHori1 );
              cargarImagen(pabellon.PublicidadHori2, this.PublicidadHori2 );
              cargarImagen(pabellon.BannerExpoHorz, this.BannerExpoHorz );


        }));

    } 
}

[System.Serializable]
    public class Pabellon
    {
    public string PublicidadVert1;
    public string PublicidadVert2;
    public string PublicidadHori1;
    public string PublicidadHori2;
    public string BannerExpoHorz;

    }

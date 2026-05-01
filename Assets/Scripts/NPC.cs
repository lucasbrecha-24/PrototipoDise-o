using UnityEngine;

public class NPC : MonoBehaviour
{
    public string mensaje = "Holaa";
    private bool distanciaPlayer = false;

    // Update is called once per frame
    void Update()
    {
        if(distanciaPlayer && Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            distanciaPlayer=true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            distanciaPlayer = false;
        }
    }

    void Interact()
    {
        Debug.Log(mensaje);
    }

}

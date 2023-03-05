namespace dispositivo{
public struct Inventario{


    List<Dispositivo> objetoLista  = new List<Dispositivo>();

    public void getDispositivos(){

        foreach(Dispositivo elemento in objetoLista){
        
            elemento.getNombre();
        }
    }

    public Inventario(){}

}
}
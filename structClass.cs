namespace dispositivo{
public struct Inventario{


    List<Dipositivo> objetoLista  = new List<Dipositivo>();

    public void getDispositivos(){

        foreach(Dipositivo elemento in objetoLista){
        
            elemento.getNombre();
        }
    }

    public Inventario(){}

}
}
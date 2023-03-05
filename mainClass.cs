namespace dispositivo{


    class mainClass{
    public static void Main(string[] args){


        DateTime fecha = new DateTime();

        Smarthphone sm1 = new Smarthphone("Pato","holaaa",222323,14,fecha);

        sm1.AgregarProducto(sm1);

        sm1.objInventario.getDispositivos();
    }
    
    
    }



    
    
}
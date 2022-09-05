Console.WriteLine("Escribe tu nombre");
String nombre = Console.ReadLine();
Console.WriteLine ("Escribe tu TI o CC");
int CC = Convert.ToInt32(Console.ReadLine ());
int zanahoria = 800;
int subprecio_Z = 0;
int cebolla = 600;
int subprecio_c = 0;
int  tomate = 500;
int subprecio_t = 0;
int papa = 2000;
int subprecio_p = 0;
int aji = 400;
int subprecio_a = 0;
int rama = 500;
int subprecio_r = 0;
int precioF = 0;
int opcion ;
do
{
  Console.WriteLine("Menu");
  Console.WriteLine("1. Zanahoria");
  Console.WriteLine("2. cebolla");
  Console.WriteLine("3. tomate");
  Console.WriteLine("4. papa");
  Console.WriteLine("5. aji");
  Console.WriteLine("6. cebolla en rama");
  Console.WriteLine("7. salir");
  Console.WriteLine("Eliga una opcion");
   opcion = Convert.ToInt32(Console.ReadLine ());
 
 
           switch (opcion)
    {
        case 1:
            Console.WriteLine("cuntas libras quiere");
            int libras = Convert.ToInt32( Console.ReadLine ());
            {subprecio_Z=libras*zanahoria;}
            Console.WriteLine("precio de la libra es " +zanahoria );
            Console.WriteLine("subprecio " +subprecio_Z);
            break;

        case 2:
           Console.WriteLine("cuntas libras quiere");
            int libras2 = Convert.ToInt32( Console.ReadLine ());
            {subprecio_c=libras2*cebolla;}
            Console.WriteLine("precio de la libra es " +cebolla );
            Console.WriteLine("subprecio " +subprecio_c);
            break;

       case 3:
           Console.WriteLine("cuntas libras quiere");
            int libras3 = Convert.ToInt32( Console.ReadLine ());
            {subprecio_t=libras3*tomate;}
            Console.WriteLine("precio de la libra es " +tomate );
            Console.WriteLine("subprecio " +subprecio_t);
            break;
         
      case 4:
           Console.WriteLine("cuntas libras quiere");
            int libras4 = Convert.ToInt32( Console.ReadLine ());
            {subprecio_p=libras4*papa;}
            Console.WriteLine("precio de la libra es " +papa );
            Console.WriteLine("subprecio " +subprecio_p);
            break;   

               case 5:
           Console.WriteLine("cuntas libras quiere");
            int libras5 = Convert.ToInt32( Console.ReadLine ());
            {subprecio_a=libras5*aji;}
            Console.WriteLine("precio de la libra es " +aji );
            Console.WriteLine("subprecio " +subprecio_a);
            break;
      case 6:
           Console.WriteLine("cuntas libras quiere");
            int libras6 = Convert.ToInt32( Console.ReadLine ());
            {subprecio_r=libras6*rama;}
            Console.WriteLine("precio de la libra es " +rama );
            Console.WriteLine("subprecio " +subprecio_r);
            break;

       case 7:
           Console.WriteLine("gracias por comprar "+nombre );
           Console.WriteLine("Zanahoria Lb " +zanahoria +" precio " +subprecio_Z);
           Console.WriteLine("cebolla Lb " +cebolla +" precio " +subprecio_c);
           Console.WriteLine("tomate Lb " +tomate +" precio " +subprecio_t);
           Console.WriteLine("papa Lb " +papa +" precio " +subprecio_p);
           Console.WriteLine("aji Lb " +aji +" precio " +subprecio_a);
           Console.WriteLine("cebolla en rama Lb " +rama +" precio " +subprecio_r); 
           precioF=subprecio_a+subprecio_c+subprecio_p+subprecio_r+subprecio_t+subprecio_Z; 
           Console.WriteLine("Precio total" +precioF);
            
            break;   
        default:
            Console.WriteLine("incorrecto");
            break;
    }
} while (opcion!=7);